using BusniessLayer.DTO;
using BusniessLayer.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Repository
{
    public interface IProjectRepository
    {
        void AddProjectAndProjectMember(CreateProjectDto ProjectAndmember, string Id);

        List<ProjectMemeberTeamleaderDto> AllMemberForProject();

        List<ProjectMembers> AllProject(string Id);

        List<Project> AllProject();

        List<Project> AllProjectForMember(string Id);
        void CommentInsert(Comment cm);
        void DeleteComment(int CommentId);
        void DeletePrject(int Id);

        List<IdentityUserRole<string>> GetAllMemberRole();

        Project GetProject(int ProjectId);

        //List<MemberDto> MemberForProject(int Projectid);
        List<ProjectMembers> MemberForProject(int Projectid);

        List<ProjectMembers> PrjectFormTeamLeader(string Id);
        List<Comment> ProjectComment(int ProjectId);
        void ProjectDone(int ProjectId);

        CreateProjectDto ProjectEdit(int ProjectId);

        void ProjectEditDone(CreateProjectDto Project, string Id);

        int ProjectState(int ProjectId);

        List<ProjectMangerStateDto> ProjectStateManger();

        List<Project> SearchProject(string Search);

        List<Project> SearchProjectByUserId(string Search, string MemberId);
    }
}