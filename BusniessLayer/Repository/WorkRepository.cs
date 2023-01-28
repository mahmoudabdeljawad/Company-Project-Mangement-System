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

namespace BusniessLayer.Repository
{
    public class WorkRepository : IWorkRepository
    {
        private ApplicationDbContext Context;
        private readonly UserManager<Member> userManager;

        //TeamLeader//Admin
        public WorkRepository(IHttpContextAccessor httpContext, ApplicationDbContext Context, UserManager<Member> userManager)
        {
            this.Context = Context;
            this.userManager = userManager;
        }

        public List<Work> AllWork()
        {
            return Context.Works.Include(x => x.Duty).Include(x => x.Duty.TeamMember).ToList();
        }

        //This function not only for team leader
        public List<Work> AllWorkForTeamLeaeder(string Id)
        {
            var query = (from p in Context.projects
                         join pm in Context.ProjectMembers on p.ProjectId equals pm.ProjectId
                         join s in Context.sprints on p.ProjectId equals s.ProjectId
                         join d in Context.Duties on s.SprintId equals d.SprintId
                         join w in Context.Works on d.DutyId equals w.DutyId
                         where pm.MemberId == Id
                         select w).Include(x => x.Duty).ToList();
            return query;
        }

        public List<WorkDto> WorkSearch(string Search)
        {
            var query = (from W in Context.Works

                         join d in Context.Duties on W.DutyId equals d.DutyId
                         join m in Context.Users on d.TeamMemberId equals m.Id
                         select new WorkDto
                         {
                             WorkId = W.WorkId,
                             StateId = W.StateId,
                             WorkName = W.WorkName,
                             WorkDescrption = W.WorkDescrption
                         ,
                             DutiesName = d.DutyName,
                             UserName = m.FitstName
                         }).Where(x => x.WorkName!.Contains(Search)).ToList();
            return query;
        }

        public List<Work> SearchForDutyWork(int DutyId, string Search)
        {
            var query = Context.Works.Where(x => x.DutyId == DutyId).Where(x => x.WorkName!.Contains(Search)).ToList();
            return query;
        }

        public List<Work> WorkList(int DutyId)
        {
            return Context.Works.Where(x => x.DutyId == DutyId).ToList();
        }

        public void InsertWork(Work WorkToInsert)
        {
            Context.Works.Add(WorkToInsert);
            Context.SaveChanges();
            var duties = Context.Duties.SingleOrDefault(x => x.DutyId == WorkToInsert.DutyId);
            duties.StateId = 3;
            Context.Duties.Update(duties);
            Context.SaveChanges();
        }

        public void WorkDone(int DutyId)
        {
            var duties = Context.Duties.SingleOrDefault(x => x.DutyId == DutyId);
            duties.StateId = 1;
            Context.Duties.Update(duties);
            Context.SaveChanges();
        }

        //reason for this function
        //return duties for work to check the state if complete or penting if completed cant make change in work
        public Duty DutyForWorkstate(int DutyId)
        {
            return Context.Duties.SingleOrDefault(x => x.DutyId == DutyId);
        }

        public List<WorkHistory> WorkHistory(int WorkId)
        {
            return Context.WorkHistory.Include(x => x.WorkAttachments).Include(x => x.Work).Where(x => x.WorkId == WorkId).ToList();
        }

        public List<Reject> HistoryNote(int WorkId)
        {
            return Context.Rejects.Where(x => x.WorkId == WorkId).ToList();
        }

        public List<Work> WorkEdit(int WorkId)
        {
            return Context.Works.Where(x => x.WorkId == WorkId).Include(x => x.Rejects).ToList();
        }

        public void WorkEditDone(Work WorkEdit)
        {
            var result = Context.Works.SingleOrDefault(x => x.WorkId == WorkEdit.WorkId);
            result.WorkName = WorkEdit.WorkName;
            result.WorkDescrption = WorkEdit.WorkDescrption;
            result.StateId = 3;
            Context.SaveChanges();
        }

        public Work WorkView(int WorkId)
        {
            return Context.Works.Include(x => x.WorkAttachments).Include(x => x.Rejects).SingleOrDefault(x => x.WorkId == WorkId);
        }

        //TeamLeaderWork
        public List<Work> WorkTeamLeaderView(int DutyId)
        {
            return Context.Works.Where(x => x.DutyId == DutyId).ToList();
        }

        public List<Work> WorkAction(int WorkId)
        {
            return Context.Works.Where(x => x.WorkId == WorkId).Include(x => x.WorkAttachments).Include(x => x.Rejects).ToList();
        }

        public void WorkApprove(int WorkId, int WorkAttachmentId)
        {
            var query = Context.Works.SingleOrDefault(x => x.WorkId == WorkId);
            query.StateId = 2;
            Context.Works.Update(query);
            Context.SaveChanges();
            var workhistory = new WorkHistory()
            {
                WorkId = WorkId,
                StateId = query.StateId,
                UpdateTime = DateTime.Now,
                WorkAttachmentId = WorkAttachmentId
            };
            Context.WorkHistory.Add(workhistory);
            Context.SaveChanges();
        }

        public void WorkAproveToHistory(int WorkId)
        {
        }

        public void WorkReject(int WorkId, string RejectNote, int WorkAttachmentId)
        {
            var query = Context.Works.SingleOrDefault(x => x.WorkId == WorkId);
            query.StateId = 4;
            Context.Works.Update(query);
            Context.SaveChanges();

            var workhistory = new WorkHistory()
            {
                WorkId = WorkId,
                StateId = query.StateId,
                UpdateTime = DateTime.Now,
                WorkAttachmentId = WorkAttachmentId
            };
            Context.WorkHistory.Add(workhistory);
            Context.SaveChanges();
            var rejected = new Reject()
            {
                WorkHistoryId = workhistory.Id,
                RejectedNote = RejectNote,
                RejectedDate = DateTime.Now,
                WorkId = WorkId
            };
            Context.Rejects.Add(rejected);
            Context.SaveChanges();
        }
    }
}