using BusniessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class WorkController : Controller
    {
        private readonly IWorkRepository WorkRepo;

        public WorkController(IWorkRepository WorkRepo)
        {
            this.WorkRepo = WorkRepo;
        }

        public IActionResult AllWork()
        {
            return View(WorkRepo.AllWork());
        }

        public IActionResult AllWorkForTeamLeaeder()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId

            return View(WorkRepo.AllWorkForTeamLeaeder(userId));
        }

        [HttpPost]
        public JsonResult WrokSearch(string Search)
        {
            return Json(WorkRepo.WorkSearch(Search));
        }

        public JsonResult SearchForDutyWork(int DutyId, string Search)
        {
            var query = WorkRepo.SearchForDutyWork(DutyId, Search);
            return Json(query);
        }
    }
}