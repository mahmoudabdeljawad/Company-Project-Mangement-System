using BusniessLayer.Entity;
using BusniessLayer.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class TeamLeaderController : Controller
    {
        private readonly UserManager<Member> userManager;
        private readonly ILastUpdateRepsitory lastUpdateRepsitory;
        private IRepository Repository;
        private ITeamMemberRepository Member;
        private IProjectRepository Projectrep;
        private ISprintRepository SprintRepo;
        private IWorkRepository WorkRepository;
        private IWorkAttacRepository WorkAttacRepository;
        private IDutiesRepository DutiesRepository;

        public TeamLeaderController(IWorkAttacRepository WorkAttacRepository
            , IDutiesRepository DutiesRepository,
            IWorkRepository WorkRepository,
            ISprintRepository SprintRepo,
            IProjectRepository Projectrep,
            ITeamMemberRepository Member,
            IRepository Repository,
            UserManager<Member> userManager,
            ILastUpdateRepsitory lastUpdateRepsitory
            )
        {
            this.SprintRepo = SprintRepo;
            this.DutiesRepository = DutiesRepository;
            this.WorkRepository = WorkRepository;
            this.WorkAttacRepository = WorkAttacRepository;
            this.Projectrep = Projectrep;
            this.userManager = userManager;
            this.lastUpdateRepsitory = lastUpdateRepsitory;
            this.Member = Member;
            this.Repository = Repository;
        }

        [Authorize]
        [Authorize(Roles = "Teamleader")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult AllTeamLeaderProjects()
        {
            var Id = Repository.CurrentLogedInId();
            ViewBag.ProjectForTeamLeaedr = Projectrep.PrjectFormTeamLeader(Id);
            ViewBag.ProjectMember = Projectrep.AllMemberForProject();
            return View();
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult SprintList(int ProjectId)
        {
            ViewBag.ProjectState = Projectrep.ProjectState(ProjectId);
            ViewBag.ProjectSprintState = SprintRepo.SprintProjectState(ProjectId);
            ViewBag.States = Repository.AllState();
            ViewBag.ProjectId = ProjectId;
            ViewBag.AllSprint = SprintRepo.AllSprint();
            return View();
        }

        [Authorize(Roles = "Teamleader")]
        [HttpGet]
        public JsonResult SprintDone(int ProjectId)
        {
            string fieldName = "Project";
            Projectrep.ProjectDone(ProjectId);
            lastUpdateRepsitory.ProjectUpdateToDone(fieldName, ProjectId);
            return Json("");
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult CreatNewSprint(int ProjectId)
        {
            ViewBag.ProjectId = ProjectId;
            return View();
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult InsertNewSprint(Sprint SprintInsert)
        {
            TempData["success"] = 1;
            int Id = SprintInsert.ProjectId;
            string fieldname = "Sprint";
            SprintRepo.InsertSprint(SprintInsert);
            lastUpdateRepsitory.NewUpdate(fieldname, SprintInsert.SprintName);
            return RedirectToAction("SprintList", new { ProjectId = SprintInsert.ProjectId });
        }

        [Authorize(Roles = "Teamleader")]
        [HttpPost]
        public JsonResult DeleteSprint(int SprintId, int ProjectId)
        {
            string FieldName = "Sprint";
            lastUpdateRepsitory.RemoveUpdateSprint(FieldName, SprintId);
            TempData["Remove"] = 1;

            SprintRepo.DeleteSprint(SprintId);
            return Json("");
        }

        [Authorize(Roles = "Teamleader")]
        public PartialViewResult SprintEdit(int SprintId)
        {
            ViewBag.Sprint = SprintRepo.SprintToEdit(SprintId);
            return PartialView("SprintEditPartial", SprintRepo.SprintToEdit(SprintId));
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult SprintEditDone(Sprint SprintToEdit)
        {
            TempData["Edit"] = 1;
            string FieldName = "Sprint";
            SprintRepo.SprintEditDone(SprintToEdit);
            lastUpdateRepsitory.EditUodate(FieldName, SprintToEdit.SprintName);
            return RedirectToAction("SprintList", new { ProjectId = SprintToEdit.ProjectId });
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult DutyList(int SprintId)
        {
            ViewBag.States = Repository.AllState();
            ViewBag.Member = Member.AllTeamMember();
            ViewBag.SprintId = SprintId;
            ViewBag.SprintState = SprintRepo.SprintState(SprintId);
            ViewBag.Count = DutiesRepository.DutyListCount(SprintId);
            ViewBag.Duties = DutiesRepository.DutyList(SprintId);
            return View();
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult CreatNewDuty(int SprintId)
        {
            ViewBag.DutyMember = DutiesRepository.TeamMemberForDuty();
            ViewBag.SprintId = SprintId;
            return View();
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult InsertDuty(Duty DutyToInsert)
        {
            TempData["success"] = 1;
            string FieldName = "Duty";

            DutiesRepository.InsertDuty(DutyToInsert);
            lastUpdateRepsitory.NewUpdate(FieldName, DutyToInsert.DutyName);
            return RedirectToAction("DutyList", new { SprintId = DutyToInsert.SprintId });
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult PartialDeleteDuty(int SprintId, int DutyId)
        {
            ViewBag.DutyId = DutyId;
            return PartialView("_DeleteDutyPartial");
        }

        [Authorize(Roles = "Teamleader")]
        [HttpPost]
        public JsonResult DeleteDuty(int SprintId, int DutyId)
        {
            string FieldName = "Duty";
            lastUpdateRepsitory.RemoveUpdateDuty(FieldName, DutyId);
            TempData["Remove"] = 1;

            DutiesRepository.DeleteDuty(DutyId);
            return Json("");
        }

        [Authorize(Roles = "Teamleader")]
        [HttpGet]
        public JsonResult DutyDone(int SprintId)
        {
            var fieldname = "Sprint";
            lastUpdateRepsitory.SprintUpdateToDone(fieldname, SprintId);
            DutiesRepository.DutyDone(SprintId);
            return Json("");
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult EditDuty(int SprintId, int DutyId)
        {
            ViewBag.AllDutiesMember = DutiesRepository.DutiesMember(SprintId);
            var duty = DutiesRepository.EditDuty(DutyId);
            return PartialView("_DutyEditModalPartial", duty);
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult EditDutyDone(Duty DutyEdit)
        {
            string FieldName = "Duty";
            TempData["Edit"] = 1;
            DutiesRepository.EditDutyDone(DutyEdit);
            lastUpdateRepsitory.EditUodate(FieldName, DutyEdit.DutyName);
            return RedirectToAction("DutyList", new { SprintId = DutyEdit.SprintId });
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult WorkView(int DutyId)
        {
            ViewBag.DutyId = DutyId;
            ViewBag.States = Repository.AllState();
            ViewBag.WorkList = WorkRepository.WorkTeamLeaderView(DutyId);
            return View();
        }

        [Authorize(Roles = "Teamleader")]
        public IActionResult WorkAction(int DutyId, int WorkId)
        {
            ViewBag.DutyId = DutyId;
            //ViewBag.States = Repository.AllState();
            //ViewBag.WorkList = Repository.WorkTeamLeaderView(DutyId);
            ViewBag.WorkAtction = WorkRepository.WorkAction(WorkId);
            return View();
        }

        [Authorize(Roles = "Teamleader")]
        [HttpPost]
        public JsonResult WorkAprove(int DutyId, int WorkId, int WorkAttachmentId)
        {
            string fieldname = "Work";
            WorkRepository.WorkApprove(WorkId, WorkAttachmentId);
            TempData["Approved"] = 1;
            lastUpdateRepsitory.WorkUpdateToApproved(fieldname, WorkId);
            return Json("");
        }

        [Authorize(Roles = "Teamleader")]
        [HttpPost]
        public IActionResult WorkReject(int DutyId, int WorkId, string RejectNote, int WorkAttachmentId)
        {
            string fieldname = "Work";
            WorkRepository.WorkReject(WorkId, RejectNote, WorkAttachmentId);
            TempData["Rejected"] = 1;
            lastUpdateRepsitory.WorkUpdateTorejected(fieldname, WorkId);
            return Json(new { redirectToUrl = Url.Action("WorkView", "TeamLeader", new { DutyId = DutyId }) });
        }

        [Authorize(Roles = "Teamleader")]
        public async Task<IActionResult> WorkHistory(int DutyId, int WorkId)
        {
            ViewBag.RejectHistory = WorkRepository.HistoryNote(WorkId);
            ViewBag.WorKAttachment = await WorkAttacRepository.Workattachment(WorkId);
            ViewBag.WorkHistory = WorkRepository.WorkHistory(WorkId);
            return View();
        }

        [Authorize(Roles = "Teamleader")]
        public async Task<FileResult> WorkAttachmentView(int WorkId)
        {
            var query = await WorkAttacRepository.Workattachmentd(WorkId);
            return File(query.File, query.ContentType);
        }

        [Authorize(Roles = "Teamleader")]
        public async Task<FileResult> WorkAttachmentHistory(int WorkAttachmentId)
        {
            var query = await WorkAttacRepository.WrokAttachmentHistory(WorkAttachmentId);
            return File(query.File, query.ContentType);
        }
    }
}