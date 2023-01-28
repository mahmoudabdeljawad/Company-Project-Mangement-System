using BusniessLayer.DTO;
using BusniessLayer.Entity;
using System.Collections.Generic;

namespace BusniessLayer.Repository
{
    public interface ILastUpdateRepsitory
    {
        List<LastUpdateDto> AllUpdate();

        void DutyUpdateToDone(string fieldname, int DutyId);

        void EditUodate(string fieldname, string name);

        void EditWorkUpdate(string fieldname, int WorkId);

        void InsertApprovedStateToLastUpdate(string fieldname, string name);

        void InsertCompletedStateToLastUpdate(string fieldname, string name);

        void InsertPendingStateToLastUpdate(string fieldname, string name);

        void InsertRejectedStateToLastUpdate(string fieldname, string name);

        void NewUpdate(string fieldname, string name);

        void ProjectUpdateToDone(string fieldname, int ProjectId);

        void RemoveUpdate(string fieldname, string name);

        void RemoveUpdateDuty(string fieldname, int DutyId);

        void RemoveUpdateSprint(string fieldname, int SprintId);

        void SprintUpdateToDone(string fieldname, int SprintId);

        void WorkUpdateToApproved(string fieldname, int WorkId);

        void WorkUpdateTorejected(string fieldname, int WorkId);
    }
}