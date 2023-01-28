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
using System.Text;
using System.Threading.Tasks;
namespace BusniessLayer.Repository
{
    public class ProjectMangerRepository : IProjectMangerRepository
    {
        private readonly IHttpContextAccessor httpContext;
        private ApplicationDbContext Context;
        private readonly UserManager<Member> userManager;
        private readonly IPasswordHasher<Member> PHash;
        //TeamLeader//Admin
        public ProjectMangerRepository(IPasswordHasher<Member> PHash
            , IHttpContextAccessor httpContext,
            ApplicationDbContext Context,
            UserManager<Member> userManager)
        {
            this.Context = Context;
            this.PHash = PHash;
            this.userManager = userManager;
            this.httpContext = httpContext;
        }
        public List<ProjectManger> AllProjectManger()
        {
            return Context.ProjectMangers.ToList();
        } 
        public List<ProjectManger> ProjectMangerSearch(string Search)
        {
            var result = Context.ProjectMangers.Where(x => x.Email!.Contains(Search)).ToList();
            return result;
        }
        public async Task InsertProjectManger(ProjectMangerDto ProjectMangerDto)
        {
            var teammember = new ProjectManger()
            {
                UserName = ProjectMangerDto.Email,
                Email = ProjectMangerDto.Email,
                EmailConfirmed = true,
                FitstName = ProjectMangerDto.FirstName,
                BandId = 1
            };
            var result = await userManager.CreateAsync(teammember, ProjectMangerDto.Password);

            var UserRole = new IdentityUserRole<string>()
            {
                UserId = teammember.Id,
                RoleId = "3"
            };
            Context.UserRoles.Add(UserRole);
            Context.SaveChanges();
        }

        public void ProjectMangerDelete(string Id)
        {
            var DeletedUser = Context.ProjectMangers.SingleOrDefault(x => x.Id == Id);
            Context.Remove(DeletedUser);
            Context.SaveChanges();
        }
        public ProjectMangerDto ProjectMangerEdit(string Id)
        {
            var Manger = Context.ProjectMangers.SingleOrDefault(x => x.Id == Id);
            var MangerDto = new ProjectMangerDto()
            {
                Email = Manger.Email,
                FirstName = Manger.FitstName,
                LastName = Manger.LastName
            };
            return MangerDto;
        }
        public async Task ProjectMangerInsert(ProjectMangerDto PManger, string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            user.UserName = PManger.Email;
            user.FitstName = PManger.FirstName;
            user.LastName = PManger.LastName;
            user.PasswordHash = PManger.Password;
            user.Email = PManger.Email;
            var Password = PHash.HashPassword(user, PManger.Password);
            user.PasswordHash = Password;
            var Result = await userManager.UpdateAsync(user);
        }
    }
}
