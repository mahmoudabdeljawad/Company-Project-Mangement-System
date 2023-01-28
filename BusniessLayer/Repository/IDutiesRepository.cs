using BusniessLayer.DTO;
using BusniessLayer.Entity;
using System.Collections.Generic;

namespace BusniessLayer.Repository
{
    public interface IDutiesRepository
    {
        List<Duty> AllDuties();

        List<Duty> AllDutiesForTeamLeader(string id);

        void DeleteDuty(int DutyId);

        List<TeamMember> DutiesMember(int SprintId);

        void DutyDone(int SprintId);

        List<Duty> DutyList(string Id);

        List<Duty> DutyList(int SprintId);

        int DutyListCount(int SprintId);

        void DutyState(int DutyId);

        Duty EditDuty(int DutyId);

        void EditDutyDone(Duty DEdit);

        void InsertDuty(Duty Obj);

        List<DutiesDto> SearchDuties(string Search);

        List<DutiesDto> SearchDuties(string id, string Search);

        List<DutiesDto> SearchDutiesBySprintId(int SprintId, string Search);

        List<DutiesDto> TeamMemberForDuty();
    }
}