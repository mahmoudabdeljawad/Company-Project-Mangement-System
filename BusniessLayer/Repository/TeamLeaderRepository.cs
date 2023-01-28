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
using System.Threading.Tasks;


namespace BusniessLayer.Repository
{
    public class TeamLeaderRepository : ITeamLeaderRepository
    {
        private readonly IHttpContextAccessor httpContext;
        private ApplicationDbContext Context;
        private readonly UserManager<Member> userManager;
        private IPasswordHasher<Member> passwordHasher;

        //TeamLeader//Admin
        public TeamLeaderRepository(IPasswordHasher<Member> passwordHasher, IHttpContextAccessor httpContext, ApplicationDbContext Context, UserManager<Member> userManager)
        {
            this.Context = Context;
            this.passwordHasher = passwordHasher;
            this.userManager = userManager;
            this.httpContext = httpContext;
        }
        public string CurrentLogedInId()
        {
            return httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public List<Teamleader> AllTeamLeader()
        {
            return Context.Teamleaders.ToList();
        } 
        public List<Teamleader> TeamLeaderSearch(string Search)
        {
            return Context.Teamleaders.Where(x=>x.Email!.Contains(Search)).ToList();
        }
       
        public async Task InsertTeamLeader(TeamleaderDto Teamleader)
        {
            var Leader = new Teamleader()
            {
                UserName = Teamleader.Email,
                Email = Teamleader.Email,
                EmailConfirmed = true,
                FitstName = Teamleader.FirstName,
                BandId = 1,
            };
            var result = await userManager.CreateAsync(Leader, Teamleader.Password);

            var UserRole = new IdentityUserRole<string>()
            {
                UserId = Leader.Id,
                RoleId = "2"
            };
            Context.UserRoles.Add(UserRole);
            Context.SaveChanges();
        }
        public void TeamLeaderDelete(string Id)
        {
            var DeletedUser = Context.Teamleaders.SingleOrDefault(x => x.Id == Id);
            Context.Remove(DeletedUser);
            Context.SaveChanges();
        }
        public TeamleaderDto TeamLeaderToEdit(string Id)
        {
            var Leader=Context.Teamleaders.SingleOrDefault(x => x.Id == Id);
            var LeaderDto = new TeamleaderDto()
            {
                Email = Leader.Email,
                FirstName = Leader.FitstName,
                LastName = Leader.LastName
            };
            return LeaderDto;
        }
        public async Task TeamLeaderInsert(TeamleaderDto Tleader, string Id)
        {
            var OldPassword = await userManager.FindByIdAsync(Id);
            var user = await userManager.FindByIdAsync(Id);
            user.UserName = Tleader.Email;
            user.FitstName = Tleader.FirstName;
            user.LastName = Tleader.LastName;
            user.Email = Tleader.Email;
            var passwordHashed= passwordHasher.HashPassword(user, Tleader.Password);
            user.PasswordHash = passwordHashed;
            var Result = await userManager.UpdateAsync(user);




        }
    }
}
