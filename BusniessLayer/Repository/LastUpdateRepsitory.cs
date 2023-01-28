using BusniessLayer.Data;
using BusniessLayer.DTO;
using BusniessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusniessLayer.Repository
{
    public class LastUpdateRepsitory : ILastUpdateRepsitory
    {
        private ApplicationDbContext Context;

        public LastUpdateRepsitory(ApplicationDbContext Context)
        {
            this.Context = Context;
        }

        public List<LastUpdateDto> AllUpdate()
        {
            var query = (from c in Context.LastUpdates
                         join s in Context.states on c.StateId equals s.StateId
                         orderby c.UpdateDate descending
                         select new LastUpdateDto
                         {
                             FieldName = c.FieldName,
                             StateId = c.StateId,
                             StateName = s.StateName,
                             Name = c.Name,
                             Id = c.Id,
                             UpdateDate = c.UpdateDate
                         }).ToList();

            return query;
        }

        public void InsertCompletedStateToLastUpdate(string fieldname, string name)
        {
            var LastUpdate = new LastUpdate()
            {
                Name = name,
                StateId = 1,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void InsertApprovedStateToLastUpdate(string fieldname, string name)
        {
            var LastUpdate = new LastUpdate()
            {
                Name = name,
                StateId = 2,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void InsertPendingStateToLastUpdate(string fieldname, string name)
        {
            var LastUpdate = new LastUpdate()
            {
                Name = name,
                StateId = 3,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void InsertRejectedStateToLastUpdate(string fieldname, string name)
        {
            var LastUpdate = new LastUpdate()
            {
                Name = name,
                StateId = 4,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void RemoveUpdate(string fieldname, string name)
        {
            var LastUpdate = new LastUpdate()
            {
                Name = name,
                StateId = 6,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void RemoveUpdateSprint(string fieldname, int SprintId)
        {
            var query = Context.sprints.SingleOrDefault(x => x.SprintId == SprintId);

            var LastUpdate = new LastUpdate()
            {
                Name = query.SprintName,
                StateId = 6,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void RemoveUpdateDuty(string fieldname, int DutyId)
        {
            var query = Context.Duties.SingleOrDefault(x => x.DutyId == DutyId);

            var LastUpdate = new LastUpdate()
            {
                Name = query.DutyName,
                StateId = 6,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void NewUpdate(string fieldname, string name)
        {
            var LastUpdate = new LastUpdate()
            {
                Name = name,
                StateId = 7,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void EditUodate(string fieldname, string name)
        {
            var LastUpdate = new LastUpdate()
            {
                Name = name,
                StateId = 8,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void EditWorkUpdate(string fieldname, int WorkId)
        {
            var query = Context.Works.SingleOrDefault(x => x.WorkId == WorkId).WorkName;
            var LastUpdate = new LastUpdate()
            {
                Name = query,
                StateId = 8,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void ProjectUpdateToDone(string fieldname, int ProjectId)
        {
            var query = Context.projects.SingleOrDefault(x => x.ProjectId == ProjectId);

            var LastUpdate = new LastUpdate()
            {
                Name = query.ProjectName,
                StateId = 1,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void SprintUpdateToDone(string fieldname, int SprintId)
        {
            var query = Context.sprints.SingleOrDefault(x => x.SprintId == SprintId);

            var LastUpdate = new LastUpdate()
            {
                Name = query.SprintName,
                StateId = 1,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void DutyUpdateToDone(string fieldname, int DutyId)
        {
            var query = Context.Duties.SingleOrDefault(x => x.DutyId == DutyId).DutyName;

            var LastUpdate = new LastUpdate()
            {
                Name = query,
                StateId = 1,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void WorkUpdateTorejected(string fieldname, int WorkId)
        {
            var query = Context.Works.SingleOrDefault(x => x.WorkId == WorkId);

            var LastUpdate = new LastUpdate()
            {
                Name = query.WorkName,
                StateId = 4,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }

        public void WorkUpdateToApproved(string fieldname, int WorkId)
        {
            var query = Context.Works.SingleOrDefault(x => x.WorkId == WorkId);

            var LastUpdate = new LastUpdate()
            {
                Name = query.WorkName,
                StateId = 2,
                UpdateDate = DateTime.Now,
                FieldName = fieldname
            };
            Context.LastUpdates.Add(LastUpdate);
            Context.SaveChanges();
        }
    }
}