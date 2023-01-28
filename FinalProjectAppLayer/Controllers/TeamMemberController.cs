using BusniessLayer.Entity;
using BusniessLayer.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class TeamMemberController : Controller
    {
        private readonly UserManager<Member> userManager;
        private readonly ILastUpdateRepsitory lastUpdateRepsitory;
        private IRepository Repository;
        private IWorkAttacRepository WorkAttachRepo;
        private IDutiesRepository DutiesRepository;
        private readonly IProjectRepository projectrep;
        private IWorkRepository WorkRepository;

        public TeamMemberController(IProjectRepository Projectrep,
            IWorkRepository WorkRepository,
            IDutiesRepository DutiesRepository,
            IWorkAttacRepository WorkAttachRepo,
            IRepository Repository,
            UserManager<Member> userManager,
            ILastUpdateRepsitory lastUpdateRepsitory)
        {
            this.WorkAttachRepo = WorkAttachRepo;
            this.projectrep = Projectrep;
            this.WorkRepository = WorkRepository;
            this.DutiesRepository = DutiesRepository;
            this.userManager = userManager;
            this.lastUpdateRepsitory = lastUpdateRepsitory;
            this.Repository = Repository;
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public async Task<IActionResult> AllTeamMemberProjects()
        {
            var user = await userManager.GetUserAsync(User);
            ViewBag.ProjectForTeamLeaedr = projectrep.PrjectFormTeamLeader(user.Id);
            ViewBag.ProjectMember = projectrep.AllMemberForProject();
            return View();
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public async Task<IActionResult> TeamMemberDutiesList()
        {
            ViewBag.State = Repository.AllState();
            var CurentUser = await userManager.GetUserAsync(User);
            var Id = CurentUser.Id;
            //string Id = Repository.CurrentLogedInId();
            ViewBag.DutiesList = DutiesRepository.DutyList(Id);
            return View();
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public IActionResult WorkList(int DutyId)
        {
            ViewBag.DutyId = DutyId;
            var worklist = WorkRepository.WorkList(DutyId);
            var count = 0;
            foreach (var item in worklist)
            {
                if (item.StateId == 2)
                {
                    count++;
                }
            }
            ViewBag.WorkCount = count;
            ViewBag.WorkList = worklist;
            ViewBag.Dutystate = WorkRepository.DutyForWorkstate(DutyId);
            ViewBag.State = Repository.AllState();
            return View();
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public IActionResult NewWork(int DutyId)
        {
            ViewBag.DutyId = DutyId;
            return View();
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        [HttpPost]
        public IActionResult InsertWork(int DutyId, Work WorkToInsert, IFormFile File)
        {
            TempData["insert"] = 1;
            string fieldName = "Work";
            WorkRepository.InsertWork(WorkToInsert);
            WorkAttachRepo.AddWorkAttachments(File, WorkToInsert.WorkId);
            lastUpdateRepsitory.NewUpdate(fieldName, WorkToInsert.WorkName);
            return RedirectToAction("WorkList", new { DutyId = DutyId });
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public async Task<FileResult> ViewAttachment(int WorkId)
        {
            var query = await WorkAttachRepo.Workattachmentd(WorkId);
            return File(query.File, query.ContentType);
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public async Task<IActionResult> WrokEdit(int DutyId, int WorkId)
        {
            ViewBag.WorkAttachment = await WorkAttachRepo.Workattachment(WorkId);
            ViewBag.WorkEdit = WorkRepository.WorkEdit(WorkId);
            return View();
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public async Task<PartialViewResult> WrokEditpartial(int DutyId, int WorkId)
        {
            ViewBag.WorkAttachment = await WorkAttachRepo.Workattachment(WorkId);
            ViewBag.WorkEdit = WorkRepository.WorkEdit(WorkId);
            return PartialView();
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        [HttpPost]
        public IActionResult WrokEditDone(int DutyId, Work workEdit, IFormFile File)
        {
            string fieldName = "Work";
            TempData["update"] = 1;
            WorkRepository.WorkEditDone(workEdit);
            WorkAttachRepo.AddWorkAttachments(File, workEdit.WorkId);
            lastUpdateRepsitory.EditWorkUpdate(fieldName, workEdit.WorkId);

            return RedirectToAction("WorkList", new { DutyId = DutyId });
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public IActionResult ViewWorkRejectedNote(int DutyId, int WorkId)
        {
            return View(WorkRepository.WorkView(WorkId));
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public PartialViewResult ViewWork(int DutyId, int WorkId)
        {
            return PartialView(WorkRepository.WorkView(WorkId));
        }

        [Authorize]
        [Authorize(Roles = "TeamMember")]
        public IActionResult WorkDone(int DutyId)
        {
            string fieldName = "Work";

            WorkRepository.WorkDone(DutyId);
            lastUpdateRepsitory.DutyUpdateToDone(fieldName, DutyId);

            return RedirectToAction("WorkList", new { DutyId = DutyId });
        }
    }
}