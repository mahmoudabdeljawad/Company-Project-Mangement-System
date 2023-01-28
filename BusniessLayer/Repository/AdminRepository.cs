using BusniessLayer.Data;
using BusniessLayer.DTO;
using BusniessLayer.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusniessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusniessLayer.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext Context;
        private readonly UserManager<Member> UserManger;
        private readonly IPasswordHasher<Member> Phash;
        private readonly IWebHostEnvironment env;

        public AdminRepository(ApplicationDbContext Context
            , IPasswordHasher<Member> Phash
            , UserManager<Member> UserManger
            , IWebHostEnvironment env
            )
        {
            this.Context = Context;
            this.env = env;
            this.Phash = Phash;
            this.UserManger = UserManger;
        }

        public List<Member> CurrentUserAync(string Id)
        {
            ///imges here
            var query = Context.Users.Where(x => x.Id == Id).ToList();

            return query;
        }

        public AdminDto ProfileAdmin(string AdminId)
        {
            var query = (from u in Context.Users
                         where u.Id == AdminId
                         select new AdminDto
                         {
                             Id = u.Id,
                             FirstName = u.FitstName,
                             LastName = u.LastName,
                             Email = u.Email,
                             ImageUrl=u.ImageUrl
                         }
                          ).SingleOrDefault();
            return query;
        }

        public async Task Img(IFormFile ImgToUpload, string Id)
        {
            var query = await Context.ProjectMembers.ToListAsync();
            string folder = "Img/Cover/";
            folder += Guid.NewGuid().ToString() + "_" + ImgToUpload.FileName;
            string serverFolder = Path.Combine(env.WebRootPath, folder);
            await ImgToUpload.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            var user = Context.Users.SingleOrDefault(x => x.Id == Id);
            user.ImageUrl = folder;

            Context.SaveChanges();
        }

        public async Task UpdateAdmin(AdminDto Admin)
        {
            var user = await UserManger.FindByIdAsync(Admin.Id);
            user.FitstName = Admin.FirstName;
            user.LastName = Admin.LastName;
            user.Email = Admin.Email;
            var newpassword = Phash.HashPassword(user, Admin.Password);
            user.PasswordHash = newpassword;
            var result = await UserManger.UpdateAsync(user);
        }

        public List<Member> AllMember()
        {
            return Context.Users.ToList();
        }

        public List<ProjectManger> AllProjectManger()
        {
            return Context.ProjectMangers.ToList();
        }

        public List<Teamleader> AllTeamLeader()
        {
            return Context.Teamleaders.ToList();
        }

        public List<TeamMember> AllTeamMember()
        {
            return Context.TeamMembers.ToList();
        }

        public List<Project> AllProject()
        {
            return Context.projects.ToList();
        }

        public List<Sprint> AllSprint()
        {
            return Context.sprints.ToList();
        }

        public List<Duty> AllDuties()
        {
            return Context.Duties.ToList();
        }

        public List<Work> AllWork()
        {
            return Context.Works.ToList();
        }

        public List<Work> AllWorkReject()
        {
            return Context.Works.Where(x => x.StateId == 4).ToList();
        }

        public List<Work> AllWorkApprove()
        {
            return Context.Works.Where(x => x.StateId == 2).ToList();
        }

        public List<Work> AllWorkPending()
        {
            return Context.Works.Where(x => x.StateId == 3).ToList();
        }

        public List<WorkAttachment> AllAttachment()
        {
            return Context.WorkAttachments.ToList();
        }
    }
}