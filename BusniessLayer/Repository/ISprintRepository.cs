using BusniessLayer.DTO;
using BusniessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Repository
{
    public interface ISprintRepository
    {
        List<Sprint> AllSprint();
        void DeleteSprint(int sprintId);
        List<Sprint> GetAllTeamLeaderSprints(string id);
        void InsertSprint(Sprint SprintInsert);
        void SprintEditDone(Sprint SprintInsert);
        int SprintProjectState(int ProjectId);
        public List<SprintDto> SprintSearch(string Search);
        List<SprintDto> SprintSearchByProjectId(int ProjectId, string Search);
        int SprintState(int Sid);
        Sprint SprintToEdit(int sprintId);
    }
}
