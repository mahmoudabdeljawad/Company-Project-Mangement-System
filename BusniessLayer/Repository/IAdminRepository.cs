using BusniessLayer.DTO;
using BusniessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusniessLayer.Repository
{
    public interface IAdminRepository
    {
        List<WorkAttachment> AllAttachment();
        List<Duty> AllDuties();
        List<Member> AllMember();
        List<Project> AllProject();
        List<ProjectManger> AllProjectManger();
        List<Sprint> AllSprint();
        List<Teamleader> AllTeamLeader();
        List<TeamMember> AllTeamMember();
        List<Work> AllWork();
        List<Work> AllWorkApprove();
        List<Work> AllWorkPending();
        List<Work> AllWorkReject();
        List<Member> CurrentUserAync(string Id);
        Task Img(IFormFile ImgToUpload, string Id);
        public AdminDto ProfileAdmin(string AdminId);
        Task UpdateAdmin(AdminDto Admin);
        
    }
}