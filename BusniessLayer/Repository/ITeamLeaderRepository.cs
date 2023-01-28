using BusniessLayer.DTO;
using BusniessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace BusniessLayer.Repository
{
    public interface ITeamLeaderRepository
    {
        List<Teamleader> AllTeamLeader();
        string CurrentLogedInId();
        Task InsertTeamLeader(TeamleaderDto Teamleader);
        void TeamLeaderDelete(string Id);
       
        public TeamleaderDto TeamLeaderToEdit(string Id);
        Task TeamLeaderInsert(TeamleaderDto Tleader, string Id);
        List<Teamleader> TeamLeaderSearch(string Search);
    }
}