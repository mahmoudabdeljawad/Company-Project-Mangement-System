using BusniessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class SprintController : Controller
    {
        private ISprintRepository Sprintrepo;

        public SprintController(ISprintRepository Sprintrepo)
        {
            this.Sprintrepo = Sprintrepo;
        }

        public IActionResult AllSprint()
        {
            return View(Sprintrepo.AllSprint());
        }

        public IActionResult AllTeamLeaderSprints()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            Sprintrepo.GetAllTeamLeaderSprints(userId);
            return View(Sprintrepo.GetAllTeamLeaderSprints(userId));
        }

        [HttpPost]
        public JsonResult SprintSearch(string Search)
        {
            var query = Sprintrepo.SprintSearch(Search);
            return Json(query);
        }

        [HttpGet]
        public JsonResult SprintSearchByProjectId(int ProjectId, string Search)
        {
            var query = Sprintrepo.SprintSearchByProjectId(ProjectId, Search);
            return Json(query);
        }
    }
}