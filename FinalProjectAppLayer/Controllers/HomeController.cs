using BusniessLayer.Data;
using FinalProjectAppLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using Microsoft.AspNetCore.Http;
using BusniessLayer.Entity;
using Microsoft.AspNetCore.Authorization;

namespace FinalProjectAppLayer.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext contexts)
        {
            _logger = logger;
            this.context = contexts;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllResult()
        {
            var query = context.projects.Include(x => x.ProjectMembers).ToArray();
            return Json(query);
        }

        //public IActionResult File()
        // {
        //     return View();
        // }
        //public async Task  <IActionResult> AllWorkAttachment()
        //{
        //    var query= await (from c in context.WorkAttachments
        //                  select c).ToListAsync();
        //    return View(query);
        //}
        //public async Task<FileResult> Download(int WorkId)
        //{
        //   var query =  await (from c in context.WorkAttachments
        //                             where c.WorkId == WorkId
        //                       select c).FirstOrDefaultAsync();
        //    return File(query.File, query.ContentType);
        //}

        //[HttpPost]
        //public IActionResult Upload(IFormFile File,int WorkId)
        //{
        //    Stream st = File.OpenReadStream();
        //    using(BinaryReader br=new BinaryReader(st))
        //    {
        //        WorkAttachment WA = new WorkAttachment();
        //        WA.WorkId = WorkId;
        //        WA.FileName = File.FileName;
        //        WA.ContentType = File.ContentType;
        //        var bytefile = br.ReadBytes((int)st.Length);
        //        WA.File = bytefile;
        //        context.WorkAttachments.Add(WA);
        //        context.SaveChanges();
        //    }

        //    return View("AllWorkAttachment");
        //}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}