using BusniessLayer.DTO;
using BusniessLayer.Entity;
using System.Collections.Generic;

namespace BusniessLayer.Repository
{
    public interface IWorkRepository
    {
        List<Work> WorkTeamLeaderView(int DutyId);
        List<Work> WorkAction(int WorkId);
        void WorkApprove(int WorkId, int WorkAttachmentId);
        List<Work> WorkList(int DutyId);
        void WorkDone(int DutyId);
        void WorkReject(int WorkId, string RejectNote, int WorkAttachmentId);
        List<WorkHistory> WorkHistory(int WorkId);
        List<Work> WorkEdit(int WorkId);
        void WorkEditDone(Work WorkEdit);

        void InsertWork(Work WorkToInsert);
        Duty DutyForWorkstate(int DutyId);
        Work WorkView(int WorkId);
        List<Reject> HistoryNote(int WorkId);
        List<Work> AllWork();
        List<WorkDto> WorkSearch(string Search);
        List<Work> SearchForDutyWork(int DutyId, string Search);
        List<Work> AllWorkForTeamLeaeder(string Id);
    }
}