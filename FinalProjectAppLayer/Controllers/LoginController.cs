using BusniessLayer.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class LoginController : Controller
    {
        private UserManager<Member> userManager;
        private SignInManager<Member> SigninManger;

        public LoginController(UserManager<Member> userManager, SignInManager<Member> SigninManger)
        {
            this.userManager = userManager;
            this.SigninManger = SigninManger;
        }

        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                if (User.IsInRole("Admin"))
                {
                    return LocalRedirect("/Admin/Index");
                }
                else if (User.IsInRole("ProjectManger"))
                {
                    return RedirectToAction("Index", "ProjectManger");
                }
                else if (User.IsInRole("Teamleader"))
                {
                    return RedirectToAction("Index", "ProjectManger");
                }
                else if (User.IsInRole("TeamMember"))
                {
                    return RedirectToAction("Index", "TeamMember");
                }
                else
                {
                    return LocalRedirect("/Identity/Account/Login");
                }
            }
            else
            {
                return LocalRedirect("/Identity/Account/Login");
            }
        }

        public IActionResult LoginPage()
        {
            return LocalRedirect("/Identity/Account/Login");
        }

        public async Task<IActionResult> Logout()
        {
            await SigninManger.SignOutAsync();
            return LocalRedirect("/Identity/Account/Login");
        }
    }
}