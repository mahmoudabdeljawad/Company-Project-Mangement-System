using BusniessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectRepository Projectrepo;

        public ProjectController(IProjectRepository Projectrepo)
        {
            this.Projectrepo = Projectrepo;
        }

        public IActionResult AllProject()
        {
            return View(Projectrepo.AllProject());
        }

        [HttpPost]
        public JsonResult SearchProjct(string Search)
        {
            var query = Projectrepo.SearchProject(Search);
            return Json(query);
        }
    }
}