using BusniessLayer.DTO;
using BusniessLayer.Entity;
using BusniessLayer.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class ProjectMangerController : Controller
    {
        private readonly UserManager<Member> userManager;
        private readonly ILastUpdateRepsitory lastUpdateRepsitory;
        private readonly ISprintRepository sprintRepository;
        private readonly IDutiesRepository dutiesRepository;
        private readonly IWorkRepository workRepository;
        private ITeamLeaderRepository Leaderrepos;
        private IRepository Repository;
        private ITeamMemberRepository Member;
        private IProjectRepository Project;

        public ProjectMangerController(IProjectRepository Project,
            ITeamMemberRepository Member,
            ITeamLeaderRepository Leaderrepos,
            IRepository Repository,
            UserManager<Member> userManager,
            ILastUpdateRepsitory lastUpdateRepsitory,
            ISprintRepository sprintRepository,
            IDutiesRepository dutiesRepository,
            IWorkRepository workRepository)
        {
            this.Leaderrepos = Leaderrepos;
            this.Project = Project;
            this.Member = Member;
            this.userManager = userManager;
            this.lastUpdateRepsitory = lastUpdateRepsitory;
            this.sprintRepository = sprintRepository;
            this.dutiesRepository = dutiesRepository;
            this.workRepository = workRepository;
            this.Repository = Repository;
        }

        [Authorize]
        [Authorize(Roles = "ProjectManger,Teamleader")]
        public IActionResult Index()
        {
            var Id = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.project = Project.AllProjectForMember(Id);
            ViewBag.sprint = sprintRepository.GetAllTeamLeaderSprints(Id);
            ViewBag.duties = dutiesRepository.AllDutiesForTeamLeader(Id);
            ViewBag.works = workRepository.AllWorkForTeamLeaeder(Id);
            return View();
        }

        [Authorize]
        [Authorize(Roles = "ProjectManger")]
        public async Task<IActionResult> AllProjectCreated(int x)
        {
            if (x == 1)
            {
                TempData["Remove"] = x;
            }
            var user = await userManager.GetUserAsync(User);
            ViewBag.ProjectMemberLeader = Project.AllMemberForProject();
            ViewBag.AllProject = Project.AllProject(user.Id);
            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<JsonResult> SearchProject(string search)
        {
            var user = await userManager.GetUserAsync(User);

            Project.SearchProjectByUserId(search, user.Id);
            var query = Project.SearchProjectByUserId(search, user.Id);
            return Json(query);
        }

        [Authorize]
        [Authorize(Roles = "ProjectManger")]
        public IActionResult InsertNewProject()
        {
            ViewBag.TeamLeader = Leaderrepos.AllTeamLeader();
            ViewBag.TeamMember = Member.AllTeamMember();

            return View();
        }

        [Authorize]
        [Authorize(Roles = "ProjectManger")]
        public IActionResult InsertDone(CreateProjectDto ProjectDto)
        {
            string fieldName = "Project";
            if (!ModelState.IsValid)
            {
                return View("InsertNewProject");
            }
            else
            {
                TempData["success"] = 1;
                lastUpdateRepsitory.NewUpdate(fieldName, ProjectDto.ProjectName);
                var Id = Repository.CurrentLogedInId();
                Project.AddProjectAndProjectMember(ProjectDto, Id);
                return RedirectToAction("AllProjectCreated");
            }
        }

        [Authorize]
        [Authorize(Roles = "ProjectManger")]
        [HttpPost]
        public JsonResult DeleteProject(int Id, string ProjectName)
        {
            string fieldname = "Project";

            lastUpdateRepsitory.RemoveUpdate(fieldname, ProjectName);
            Project.DeletePrject(Id);
            TempData["remove"] = 1;
            return Json("");
        }

        [Authorize]
        [Authorize(Roles = "ProjectManger")]
        public PartialViewResult ProjectEdit(int Projectid)
        {
            ViewBag.TeamLeader = Leaderrepos.AllTeamLeader();
            ViewBag.TeamMember = Member.AllTeamMember();
            ViewBag.MemberForProject = Project.MemberForProject(Projectid);
            return PartialView("ProjectEditPartial", Project.ProjectEdit(Projectid));
        }

        [Authorize]
        [Authorize(Roles = "ProjectManger")]
        public IActionResult ProjectEditDone(CreateProjectDto project)
        {
            if (!ModelState.IsValid)
            {
                return View("ProjectEdit");
            }
            else
            {
                TempData["Edit"] = 1;
                string FieldName = "Project";
                lastUpdateRepsitory.EditUodate(FieldName, project.ProjectName);
                var Id = userManager.GetUserId(User);
                Project.ProjectEditDone(project, Id);
                return RedirectToAction("AllProjectCreated");
            }
        }

        public IActionResult ProjectView(int ProjectId)
        {
            ViewBag.Id = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.comment = Project.ProjectComment(ProjectId);
            return View(Project.GetProject(ProjectId));
        }

        public IActionResult Commentinsert(Comment Cm)
        {
            TempData["AddComment"] = 1;
            Cm.dateTime = DateTime.Now;
            Cm.MemberId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Project.CommentInsert(Cm);
            return RedirectToAction("ProjectView", new { ProjectId = Cm.ProjectId });
        }

        [HttpPost]
        public JsonResult DeleteComent(int CommentId)
        {
            TempData["RemoveComment"] = 1;
            Project.DeleteComment(CommentId);
            return Json("");
        }
    }
}