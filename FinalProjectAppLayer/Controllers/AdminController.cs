using BusniessLayer.DTO;
using BusniessLayer.Entity;
using BusniessLayer.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<Member> userManager;
        private readonly IWebHostEnvironment env;
        private readonly SignInManager<Member> signInManager;
        private ITeamLeaderRepository Leaderrepos;
        private IProjectMangerRepository Manger;
        private IRepository Repository;
        private IAdminRepository AdminRepo;
        private IProjectRepository projectRepository;
        private ILastUpdateRepsitory lastUpdateRepsitory;
        private readonly ITeamMemberRepository Member;

        public AdminController(SignInManager<Member> signInManager,
            IAdminRepository AdminRepo,
            ITeamMemberRepository Member,
            IProjectMangerRepository Manger,
            ITeamLeaderRepository Leaderrepos,
            IRepository Repository,
            UserManager<Member> userManager,
            IWebHostEnvironment env,
             IProjectRepository projectRepository, ILastUpdateRepsitory lastUpdateRepsitory)
        {
            this.Leaderrepos = Leaderrepos;
            this.signInManager = signInManager;
            this.AdminRepo = AdminRepo;
            this.Member = Member;
            this.Manger = Manger;
            this.userManager = userManager;
            this.env = env;
            this.Repository = Repository;
            this.projectRepository = projectRepository;
            this.lastUpdateRepsitory = lastUpdateRepsitory;

            //async Task <IdentityUser> getCurrentUser()
            // {
            //     var user =await userManager.GetUserAsync(User);
            //     return user;
            // }
            // var user = getCurrentUser();
            // //string Id = user.Id;
            // ViewBag.ProfileImage = AdminRepo.GetCurrentUserImage("");
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);
            ViewBag.CurrentUserData = AdminRepo.CurrentUserAync(user.Id);
            ViewBag.AllProject = AdminRepo.AllProject().Count;
            ViewBag.AllMember = AdminRepo.AllMember().Count;
            ViewBag.AllProjectManger = AdminRepo.AllProjectManger().Count;
            ViewBag.AllTeamLeader = AdminRepo.AllTeamLeader().Count;
            ViewBag.AllTeamMember = AdminRepo.AllTeamMember().Count;
            ViewBag.AllSprint = AdminRepo.AllSprint().Count;
            ViewBag.AllDuties = AdminRepo.AllDuties().Count;
            ViewBag.AllWork = AdminRepo.AllWork().Count;
            ViewBag.AllWorkPending = AdminRepo.AllWorkPending().Count;
            ViewBag.AllWorkApprove = AdminRepo.AllWorkApprove().Count;
            ViewBag.AllWorkReject = AdminRepo.AllWorkReject().Count;
            ViewBag.AllWorkAttachment = AdminRepo.AllAttachment().Count;
            ViewBag.ProjectMangerState = projectRepository.ProjectStateManger();
            ViewBag.LastUpdate = lastUpdateRepsitory.AllUpdate();
            return View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult AllProjectManger()
        {
            ViewBag.AllProjectManger = Manger.AllProjectManger();
            return View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult ProjectMangerSearch(string SearchAjax)
        {
            var query = Manger.ProjectMangerSearch(SearchAjax);
            return Json(query);
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult ProjectMangerDelete(string Id)
        {
            TempData["Remove"] = 1;

            Manger.ProjectMangerDelete(Id);
            return RedirectToAction("AllProjectManger");
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult AddProjectManger()
        {
            return View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> InsertProjectManger(ProjectMangerDto ProjectMangerDto)
        {
            TempData["success"] = 1;
            await Manger.InsertProjectManger(ProjectMangerDto);
            return RedirectToAction("AllProjectManger");
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult ProjectMangerEdit(string Id)
        {
            ViewBag.Id = Id;
            return View(Manger.ProjectMangerEdit(Id));
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ProjectMangerInsert(ProjectMangerDto PManger, string Id)
        {
            if (ModelState.IsValid)
            {
                await Manger.ProjectMangerInsert(PManger, Id);
            }
            TempData["Edit"] = 1;

            return RedirectToAction("AllProjectManger");
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult AllTeamLeader()
        {
            ViewBag.TeamLeader = Leaderrepos.AllTeamLeader();
            return View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public JsonResult TeamLeaderSearch(string SearchAjax)
        {
            var query = Leaderrepos.TeamLeaderSearch(SearchAjax);
            return Json(query);
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult AddTeamLeader()
        {
            return View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> InsertTeamleader(TeamleaderDto teamleader)
        {
            TempData["success"] = 1;

            await Leaderrepos.InsertTeamLeader(teamleader);
            return RedirectToAction("AllTeamLeader");
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult TeamLeaderDelete(String Id)
        {
            Leaderrepos.TeamLeaderDelete(Id);
            TempData["Remove"] = 1;

            return RedirectToAction("AllTeamLeader");
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult TeamleaderEdit(string Id)
        {
            ViewBag.Id = Id;
            return View(Leaderrepos.TeamLeaderToEdit(Id));
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> TeamleaderInsert(TeamleaderDto TLeaeder, string Id)
        {
            if (ModelState.IsValid)
            {
                TempData["Edit"] = 1;

                await Leaderrepos.TeamLeaderInsert(TLeaeder, Id);
            }
            return RedirectToAction("AllTeamLeader");
        }

        ///////////////TeamMember///////////////////////////////////
        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult AllTeamMember()
        {
            ViewBag.AllTeamMember = Member.AllTeamMember();
            return View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public JsonResult TeamMemberSearch(string SearchAjax)
        {
            var query = Member.TeamMemberSearch(SearchAjax);
            return Json(query);
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult TeamMemberDelete(string Id)
        {
            TempData["Remove"] = 1;

            Member.TeamMemberDelete(Id);
            return RedirectToAction("AllTeamMember");
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult NewTeamMember()
        {
            return View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> InsertTeamMember(TeamMemberDto TeamMember)
        {
            if (ModelState.IsValid)
            {
                TempData["success"] = 1;

                await Member.InsertTeamMember(TeamMember);
                return RedirectToAction("AllTeamMember");
            }
            else return View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult TeamMemberEdit(string Id)
        {
            ViewBag.Id = Id;
            return View(Member.TeamMemberToEdit(Id));
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> TeamMemberInsert(TeamMemberDto TM, string Id)
        {
            TempData["Edit"] = 1;

            await Member.TeamMemberInsert(TM, Id);
            return RedirectToAction("AllTeamMember");
        }

        [Authorize]
        public async Task<IActionResult> ProfileAdmin()
        {
            var user = await userManager.GetUserAsync(User);
            var query = AdminRepo.ProfileAdmin(user.Id);
            return View(query);
        }

        [Authorize]
        public async Task<IActionResult> ProfileEdit(AdminDto admin, IFormFile Img)
        {
            await AdminRepo.Img(Img, admin.Id);
            await AdminRepo.UpdateAdmin(admin);
            return RedirectToAction("ProfileAdmin");
        }
    }
}