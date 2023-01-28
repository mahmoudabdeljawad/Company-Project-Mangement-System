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
    public class TeamMemberRepository :ITeamMemberRepository
    {
        private readonly IHttpContextAccessor httpContext;
        private ApplicationDbContext Context;
        private readonly UserManager<Member> userManager;  
        private readonly IPasswordHasher<Member> PHash;
        //TeamLeader//Admin
        public TeamMemberRepository(IPasswordHasher<Member> PHash, IHttpContextAccessor httpContext, ApplicationDbContext Context, UserManager<Member> userManager)
        {
            this.Context = Context;
            this.PHash = PHash;
            this.userManager = userManager;
            this.httpContext = httpContext;
        }
        public List<TeamMember> AllTeamMember()
        {
            return Context.TeamMembers.ToList();
        }  
        public List<TeamMember> TeamMemberSearch(string Search)
        {
            return Context.TeamMembers.Where(x=>x.Email!.Contains(Search)).ToList();
        }
        public async Task InsertTeamMember(TeamMemberDto TMS)
        {
            var teammember = new TeamMember()
            {
                UserName = TMS.Email,
                Email = TMS.Email,
                EmailConfirmed = true,
                FitstName = TMS.FirstName,
                LastName=TMS.LastName,
                BandId = 1
            };
            var result = await userManager.CreateAsync(teammember, TMS.Password);

            var UserRole = new IdentityUserRole<string>()
            {
                UserId = teammember.Id,
                RoleId = "1"
            };
            Context.UserRoles.Add(UserRole);
            Context.SaveChanges();

        }
        public void TeamMemberDelete(string Id)
        {
            var DeletedUser = Context.TeamMembers.SingleOrDefault(x => x.Id == Id);
            Context.Remove(DeletedUser);
            Context.SaveChanges();
        }
        public TeamMemberDto TeamMemberToEdit(string Id)
        {
            var Member = Context.TeamMembers.SingleOrDefault(x => x.Id == Id);
            var MemberDto = new TeamMemberDto()
            {
                FirstName = Member.FitstName,
                LastName = Member.LastName,
                Email = Member.Email,
            };
            return MemberDto;
        }
        public async Task TeamMemberInsert(TeamMemberDto TM,string Id)
        {
           var user = await userManager.FindByIdAsync(Id);


            user.Email = TM.Email;
            user.UserName = TM.Email;
            user.FitstName = TM.FirstName;
            user.LastName = TM.LastName;
          
            var Password = PHash.HashPassword(user, TM.Password);
            user.PasswordHash = Password;
            var Result = await userManager.UpdateAsync(user);
            
           
        }
    }
}
