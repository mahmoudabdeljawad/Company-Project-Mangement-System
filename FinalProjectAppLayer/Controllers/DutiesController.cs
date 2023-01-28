using BusniessLayer.Data;
using BusniessLayer.Entity;
using BusniessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class DutiesController : Controller
    {
        private IDutiesRepository DutiesRepo;

        public DutiesController(IDutiesRepository DutiesRepo)
        {
            this.DutiesRepo = DutiesRepo;
        }

        public IActionResult AllDuties()
        {
            return View(DutiesRepo.AllDuties());
        }

        public IActionResult AllDutiesForTeamLeader()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId

            return View(DutiesRepo.AllDutiesForTeamLeader(userId));
        }

        [HttpPost]
        public JsonResult SearchDuties(string Search)
        {
            var query = DutiesRepo.SearchDuties(Search);
            return Json(query);
        }

        public JsonResult SearchDutiesForTeamMember(string Search)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId

            var query = DutiesRepo.SearchDuties(userId, Search);
            return Json(query);
        }

        public JsonResult SearchDutiesBySprintId(int SprintId, string Search)
        {
            var query = DutiesRepo.SearchDutiesBySprintId(SprintId, Search);
            return Json(query);
        }
    }
}