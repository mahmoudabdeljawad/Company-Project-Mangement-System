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

namespace BusniessLayer.Repository
{
    public class Repository : IRepository 
    {
        private readonly IHttpContextAccessor httpContext;
        private ApplicationDbContext Context;
        private readonly UserManager<Member> userManager;
        //TeamLeader//Admin
        public Repository(IHttpContextAccessor httpContext, ApplicationDbContext Context, UserManager<Member> userManager)
        {
            this.Context = Context;
            this.userManager = userManager;
            this.httpContext = httpContext;
        }
        //GetCurrentLoggedInTeamLeaderID////////////////////////////////////////////////
        public string CurrentLogedInId()
        {
            return httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public List<State> AllState()
        {
            return Context.states.ToList();
        }

      
       
       
    }
}
