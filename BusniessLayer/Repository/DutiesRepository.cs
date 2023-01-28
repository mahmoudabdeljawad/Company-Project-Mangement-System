using BusniessLayer.Data;
using BusniessLayer.DTO;
using BusniessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BusniessLayer.Repository
{
    public class DutiesRepository : IDutiesRepository
    {
        private ApplicationDbContext Context;
        private readonly UserManager<Member> userManager;

        //TeamLeader//Admin
        public DutiesRepository(ApplicationDbContext Context, UserManager<Member> userManager)
        {
            this.Context = Context;
            this.userManager = userManager;
        }

        public List<Duty> AllDuties()
        {
            return Context.Duties.Include(x => x.TeamMember).Include(x => x.Sprint).ToList();
        }

        // this function not only for team leader
        public List<Duty> AllDutiesForTeamLeader(string id)
        {
            var query = (from p in Context.projects
                         join pm in Context.ProjectMembers on p.ProjectId equals pm.ProjectId
                         join s in Context.sprints on p.ProjectId equals s.ProjectId
                         join d in Context.Duties on s.SprintId equals d.SprintId
                         where pm.MemberId == id
                         select d).Include(x => x.Sprint).Include(x => x.TeamMember).ToList();
            return query;
        }

        public List<TeamMember> DutiesMember(int SprintId)
        {
            var query = (from s in Context.sprints
                         where s.SprintId == SprintId
                         join p in Context.projects on s.ProjectId equals p.ProjectId
                         join pm in Context.ProjectMembers on s.ProjectId equals pm.ProjectId
                         join t in Context.TeamMembers on pm.MemberId equals t.Id
                         select new TeamMember { Id = t.Id, UserName = t.UserName }

                        ).ToList();
            return query;
        }

        public List<DutiesDto> SearchDuties(string Search)
        {
            var query = (from d in Context.Duties
                         join s in Context.sprints on d.SprintId equals s.SprintId
                         join m in Context.Users on d.TeamMemberId equals m.Id
                         select new DutiesDto
                         {
                             DutyDescrption = d.DutyDescrption,
                             DutyName = d.DutyName,
                             DutyId = d.DutyId,
                             UserName = m.FitstName,
                             SprintName = s.SprintName
                         }
                         ).Where(x => x.DutyName!.Contains(Search)).ToList();
            return query;
        }

        public List<DutiesDto> SearchDuties(string id, string Search)
        {
            var query = (from d in Context.Duties
                         join s in Context.sprints on d.SprintId equals s.SprintId
                         join m in Context.Users on d.TeamMemberId equals m.Id
                         where m.Id == id
                         select new DutiesDto
                         {
                             DutyDescrption = d.DutyDescrption,
                             DutyName = d.DutyName,
                             DutyId = d.DutyId,
                             UserName = m.FitstName,
                             SprintName = s.SprintName
                         }
                         ).Where(x => x.DutyName!.Contains(Search)).ToList();
            return query;
        }

        public List<DutiesDto> SearchDutiesBySprintId(int SprintId, string Search)
        {
            var query = (from d in Context.Duties
                         join s in Context.sprints on d.SprintId equals s.SprintId
                         join m in Context.Users on d.TeamMemberId equals m.Id
                         where d.SprintId == SprintId
                         select new DutiesDto
                         {
                             DutyDescrption = d.DutyDescrption,
                             DutyName = d.DutyName,
                             DutyId = d.DutyId,
                             UserName = m.FitstName,
                             SprintName = s.SprintName
                         }
                         ).Where(x => x.DutyName!.Contains(Search)).ToList();
            return query;
        }

        //Duties/////
        public List<DutiesDto> TeamMemberForDuty()
        {
            var query = (from s in Context.sprints
                         join p in Context.ProjectMembers on s.ProjectId equals p.ProjectId
                         join ur in Context.UserRoles on p.MemberId equals ur.UserId
                         join r in Context.Roles on ur.RoleId equals r.Id
                         join m in Context.TeamMembers on p.MemberId equals m.Id
                         select new DutiesDto { RoleName = r.Name, UserName = m.UserName, SprintId = s.SprintId, MemberId = m.Id }
                       ).ToList();
            return query;
        }

        public List<Duty> DutyList(string Id)
        {
            return Context.Duties.Where(x => x.TeamMemberId == Id).ToList();
        }

        // function to set sate of duties based on worked if all approve will set completed else nothing will change
        public void DutyState(int DutyId)
        {
            var count = 0;
            var work = Context.Works.Where(x => x.DutyId == DutyId).ToList();
            foreach (var item in work)
            {
                if (item.StateId == 1 || item.StateId == 2)
                {
                    count++;
                }
            }
            if (work.Count() == count)
            {
                var duties = Context.Duties.SingleOrDefault(x => x.DutyId == DutyId);
                duties.StateId = 1;
                Context.Duties.Update(duties);
                Context.SaveChanges();
            }
        }

        public List<Duty> DutyList(int SprintId)
        {
            return Context.Duties.Where(x => x.SprintId == SprintId).ToList();
        }

        public int DutyListCount(int SprintId)
        {
            var Duty = Context.Duties.Where(x => x.SprintId == SprintId).ToList();
            var Count = 0;
            foreach (var item in Duty)
            {
                if (item.StateId == 1)
                {
                    Count++;
                }
            }
            return Count;
        }

        public void InsertDuty(Duty Obj)
        {
            Context.Duties.Add(Obj);
            Context.SaveChanges();
            Context.sprints.SingleOrDefault(x => x.SprintId == Obj.SprintId).StateId = 3;
            Context.SaveChanges();
        }

        public void DeleteDuty(int DutyId)
        {
            var deleteduty = Context.Duties.SingleOrDefault(x => x.DutyId == DutyId);
            Context.Duties.Remove(deleteduty);
            Context.SaveChanges();
        }

        //This function to call win Duty done presed It Make State of Sprint For Duty Complete after Submit All duties and completed
        public void DutyDone(int SprintId)
        {
            var sprint = Context.sprints.SingleOrDefault(x => x.SprintId == SprintId);
            sprint.StateId = 1;
            Context.SaveChanges();
        }

        public Duty EditDuty(int DutyId)
        {
            return Context.Duties.Include(x => x.TeamMember).SingleOrDefault(x => x.DutyId == DutyId);
        }

        public void EditDutyDone(Duty DEdit)
        {
            var duty = Context.Duties.SingleOrDefault(x => x.DutyId == DEdit.DutyId);

            duty.DutyName = DEdit.DutyName;
            duty.DutyDescrption = DEdit.DutyDescrption;
            duty.TeamMemberId = DEdit.TeamMemberId;

            Context.SaveChanges();
        }
    }
}