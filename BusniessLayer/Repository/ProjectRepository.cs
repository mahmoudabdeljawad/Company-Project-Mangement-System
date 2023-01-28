using BusniessLayer.Data;
using BusniessLayer.DTO;
using BusniessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLayer.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IHttpContextAccessor httpContext;
        private ApplicationDbContext Context;
        private readonly UserManager<Member> userManager;

        //TeamLeader//Admin
        public ProjectRepository(IHttpContextAccessor httpContext, ApplicationDbContext Context, UserManager<Member> userManager)
        {
            this.Context = Context;
            this.userManager = userManager;
            this.httpContext = httpContext;
        }

        public List<Project> AllProject()
        {
            var query = Context.projects.ToList();
            return query;
        }

        public Project GetProject(int ProjectId)
        {
            var query = Context.projects.Where(x => x.ProjectId == ProjectId).Include(x => x.Sprints).SingleOrDefault();
            return query;
        }

        public List<Project> AllProjectForMember(string Id)
        {
            var query = (from p in Context.projects
                         join pm in Context.ProjectMembers on p.ProjectId equals pm.ProjectId
                         where pm.MemberId == Id
                         select p
                         ).ToList();
            return query;
        }

        public List<ProjectMangerStateDto> ProjectStateManger()
        {
            var query = (from p in Context.projects
                         join pm in Context.ProjectMembers on p.ProjectId equals pm.ProjectId
                         join m in Context.Users on pm.MemberId equals m.Id
                         join ur in Context.UserRoles on m.Id equals ur.UserId
                         where ur.RoleId == "3"
                         select new ProjectMangerStateDto
                         {
                             Id = m.Id,
                             ProjectName = p.ProjectName,
                             DeadLine = p.DeadLine
                         ,
                             MangerName = m.FitstName,
                             MangerLastName = m.LastName,
                             ImageUrl = m.ImageUrl,
                             StateId = p.StateId
                         }).ToList();

            //var Project = Context.projects.Include(x => x.ProjectMembers).ToList();
            //var RoleMember = Context.UserRoles.ToList();
            //List<Project> AllProject = new List<Project>();
            //foreach (var P in Project)
            //{
            //    foreach (var Pm in P.ProjectMembers)
            //    {
            //        foreach (var Rm in RoleMember)
            //        {
            //            if (Rm.UserId == P.ProjectMembers.)
            //    }
            //    }
            //}
            return query;
        }

        public List<IdentityUserRole<string>> GetAllMemberRole()
        {
            var query = Context.UserRoles.ToList();
            return query;
        }

        public int ProjectState(int ProjectId)
        {
            var query = Context.projects.SingleOrDefault(x => x.ProjectId == ProjectId).StateId;
            return query;
        }

        public void ProjectDone(int ProjectId)
        {
            var ProjectDone = Context.projects.SingleOrDefault(x => x.ProjectId == ProjectId);
            ProjectDone.StateId = 1;
            Context.SaveChanges();
        }

        public List<Project> SearchProject(string Search)
        {
            return Context.projects.Where(x => x.ProjectName!.Contains(Search)).ToList();
        }

        public List<Project> SearchProjectByUserId(string Search, string MemberId)
        {
            var query = (from p in Context.projects
                         join pm in Context.ProjectMembers on p.ProjectId equals pm.ProjectId
                         where pm.MemberId == MemberId
                         select p

                       ).Where(x => x.ProjectName!.Contains(Search)).ToList();
            return query;
        }

        public List<ProjectMembers> AllProject(string Id)
        {
            var query = Context.ProjectMembers.Include(x => x.Project).Where(x => x.MemberId == Id).ToList();
            return query;
        }

        public void DeletePrject(int Id)
        {
            var DeleteProject = Context.projects.SingleOrDefault(x => x.ProjectId == Id);
            Context.projects.Remove(DeleteProject);
            Context.SaveChanges();
        }

        public void AddProjectAndProjectMember(CreateProjectDto ProjectAndmember, string Id)
        {
            var Project = new Project()
            {
                ProjectName = ProjectAndmember.ProjectName,
                ProjectDescrption = ProjectAndmember.Descrption,
                DeadLine = ProjectAndmember.Deadline,
                StateId = 3
            };
            Context.projects.Add(Project);
            Context.SaveChanges();
            var ProjectLeader = new ProjectMembers()
            {
                ProjectId = Project.ProjectId,

                MemberId = ProjectAndmember.TeamLeaderId
            };
            Context.ProjectMembers.Add(ProjectLeader);
            Context.SaveChanges();
            var ProjectManger = new ProjectMembers()
            {
                ProjectId = Project.ProjectId,

                MemberId = Id
            };
            Context.ProjectMembers.Add(ProjectManger);
            Context.SaveChanges();

            foreach (var item in ProjectAndmember.ProjectMemberId)
            {
                var ProjectMember = new ProjectMembers()
                {
                    ProjectId = Project.ProjectId,

                    MemberId = item
                };
                Context.ProjectMembers.Add(ProjectMember);
                Context.SaveChanges();
            }
        }

        public List<ProjectMemeberTeamleaderDto> AllMemberForProject()
        {
            var query = (from m in Context.Users
                         join pm in Context.ProjectMembers on m.Id equals pm.MemberId
                         join p in Context.projects on pm.ProjectId equals p.ProjectId
                         join ur in Context.UserRoles on m.Id equals ur.UserId
                         join r in Context.Roles on ur.RoleId equals r.Id
                         select new ProjectMemeberTeamleaderDto
                         {
                             Id = pm.MemberId,
                             UserName = m.UserName
                         ,
                             ProjectId = pm.ProjectId,
                             ProjectName = p.ProjectName,
                             RoleName = r.Name
                         }
                         ).ToList();
            return query;
        }

        public CreateProjectDto ProjectEdit(int ProjectId)
        {
            var project = Context.projects.SingleOrDefault(x => x.ProjectId == ProjectId);
            var projectDto = new CreateProjectDto()
            {
                ProjectId = project.ProjectId,
                ProjectName = project.ProjectName,
                Descrption = project.ProjectDescrption,
                Deadline = project.DeadLine,
            };
            return projectDto;
        }

        public void ProjectEditDone(CreateProjectDto Project, string Id)
        {
            var ProjectToUpdate = Context.projects.SingleOrDefault(x => x.ProjectId == Project.ProjectId);
            ProjectToUpdate.ProjectId = Project.ProjectId;
            ProjectToUpdate.ProjectName = Project.ProjectName;
            ProjectToUpdate.ProjectId = Project.ProjectId;
            ProjectToUpdate.ProjectDescrption = Project.Descrption;
            ProjectToUpdate.DeadLine = Project.Deadline;
            Context.projects.Update(ProjectToUpdate);
            Context.SaveChanges();
            var queryForMember = (from c in Context.TeamMembers
                                  join pm in Context.ProjectMembers on c.Id equals pm.MemberId
                                  where pm.ProjectId == Project.ProjectId
                                  select new ProjectMembers { MemberId = pm.MemberId, ProjectId = pm.ProjectId }
                       ).ToList();
            foreach (var item in queryForMember)
            {
                Context.ProjectMembers.Remove(item);
                Context.SaveChanges();
            }
            foreach (var i in Project.ProjectMemberId)
            {
                var Memberupdate = new ProjectMembers()
                {
                    MemberId = i,
                    ProjectId = Project.ProjectId
                };
                Context.ProjectMembers.Add(Memberupdate);
                Context.SaveChanges();
            }
            var queryForleader = (from c in Context.Teamleaders
                                  join pm in Context.ProjectMembers on c.Id equals pm.MemberId
                                  select new ProjectMembers { MemberId = pm.MemberId, ProjectId = pm.ProjectId }
                     ).SingleOrDefault(x => x.ProjectId == Project.ProjectId);

            Context.ProjectMembers.Remove(queryForleader);
            Context.SaveChanges();
            var TeamLeader = new ProjectMembers()
            {
                MemberId = Project.TeamLeaderId,
                ProjectId = Project.ProjectId
            };
            Context.ProjectMembers.Add(TeamLeader);
            Context.SaveChanges();
        }

        public List<ProjectMembers> MemberForProject(int Projectid)
        {
            var x = Context.ProjectMembers.Where(x => x.ProjectId == Projectid).ToList();
            return x;
        }

        public List<ProjectMembers> PrjectFormTeamLeader(string Id)
        {
            var query = Context.ProjectMembers.Include(p => p.Project).Where(x => x.MemberId == Id).ToList();
            return query;
        }

        public void CommentInsert(Comment cm)
        {
            Context.Comments.Add(cm);
            Context.SaveChanges();
        }

        public List<Comment> ProjectComment(int ProjectId)
        {
            return Context.Comments.Include(x => x.Member).Where(x => x.ProjectId == ProjectId).ToList();
        }

        public void DeleteComment(int CommentId)
        {
            var DeleteComment = Context.Comments.Where(x => x.Commentid == CommentId).SingleOrDefault();
            Context.Comments.Remove(DeleteComment);
            Context.SaveChanges();
        }
    }
}