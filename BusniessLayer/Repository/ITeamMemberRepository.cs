using BusniessLayer.DTO;
using BusniessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLayer.Repository
{
    public interface ITeamMemberRepository
    {
        List<TeamMember> AllTeamMember();
        Task InsertTeamMember(TeamMemberDto TMS);
        void TeamMemberDelete(string Id);
        Task TeamMemberInsert(TeamMemberDto TM, string Id);
        List<TeamMember> TeamMemberSearch(string Search);
        TeamMemberDto TeamMemberToEdit(string Id);
    }
}
