using BusniessLayer.Data;
using BusniessLayer.DTO;
using BusniessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusniessLayer.Repository
{
    public class SprintRepository : ISprintRepository
    {
        private ApplicationDbContext Context;
        private readonly UserManager<Member> userManager;

        //TeamLeader//Admin
        public SprintRepository(ApplicationDbContext Context, UserManager<Member> userManager)
        {
            this.Context = Context;
            this.userManager = userManager;
        }

        public int SprintProjectState(int ProjectId)
        {
            var count = 0;
            var query = Context.sprints.Where(x => x.ProjectId == ProjectId).ToList();
            foreach (var item in query)
            {
                if (item.StateId == 1)
                {
                    count++;
                }
            }
            if (query.Count == 0)
            {
                return 0;
            }
            else if (query.Count == count)
            {
                return 1;
            }
            else return 2;
        }

        public int SprintState(int Sid)
        {
            var query = Context.sprints.SingleOrDefault(x => x.SprintId == Sid);

            return query.StateId;
        }

        public void InsertSprint(Sprint SprintInsert)
        {
            Context.sprints.Add(SprintInsert);
            Context.SaveChanges();
        }

        public List<Sprint> AllSprint()
        {
            return Context.sprints.Include(x => x.Project).ToList();
        }

        // this function not just for team leader
        public List<Sprint> GetAllTeamLeaderSprints(string id)
        {
            var query = (from p in Context.projects
                         join pm in Context.ProjectMembers on p.ProjectId equals pm.ProjectId
                         join s in Context.sprints on p.ProjectId equals s.ProjectId
                         where pm.MemberId == id
                         select s).Include(x => x.Project).ToList();
            return query;
        }

        public List<SprintDto> SprintSearch(string Search)
        {
            var query = (from s in Context.sprints
                         join p in Context.projects on s.ProjectId equals p.ProjectId

                         select new SprintDto
                         {
                             ProjectName = p.ProjectName,
                             SprintId = s.SprintId,
                             sprintDescrption = s.sprintDescrption
                         ,
                             SprintName = s.SprintName,
                             StartDate = s.StartDate,
                             EndDate = s.EndDate,
                             StateId = s.StateId
                         }
                        ).Where(x => x.SprintName!.Contains(Search)).ToList();
            return query;
        }

        public List<SprintDto> SprintSearchByProjectId(int ProjectId, string Search)
        {
            var query = (from s in Context.sprints
                         join p in Context.projects on s.ProjectId equals p.ProjectId
                         where s.ProjectId == ProjectId
                         select new SprintDto
                         {
                             ProjectName = p.ProjectName,
                             SprintId = s.SprintId,
                             sprintDescrption = s.sprintDescrption
                         ,
                             SprintName = s.SprintName,
                             StartDate = s.StartDate,
                             EndDate = s.EndDate,
                             StateId = s.StateId
                         }
                        ).Where(x => x.SprintName!.Contains(Search)).ToList();
            return query;
        }

        public void DeleteSprint(int sprintId)
        {
            var delete = Context.sprints.SingleOrDefault(x => x.SprintId == sprintId);

            Context.sprints.Remove(delete);
            Context.SaveChanges();
        }

        public Sprint SprintToEdit(int sprintId)
        {
            return Context.sprints.SingleOrDefault(x => x.SprintId == sprintId);
        }

        public void SprintEditDone(Sprint SprintInsert)
        {
            var SInsert = Context.sprints.SingleOrDefault(x => x.SprintId == SprintInsert.SprintId);
            SInsert.SprintName = SprintInsert.SprintName;
            SInsert.sprintDescrption = SprintInsert.sprintDescrption;
            SInsert.StartDate = SprintInsert.StartDate;
            SInsert.EndDate = SprintInsert.EndDate;
            Context.SaveChanges();
        }
    }
}