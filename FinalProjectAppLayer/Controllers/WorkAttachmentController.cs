using BusniessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAppLayer.Controllers
{
    public class WorkAttachmentController : Controller
    {
        private readonly IWorkAttacRepository Attachrepo;
        public WorkAttachmentController(IWorkAttacRepository Attachrepo)
        {
            this.Attachrepo = Attachrepo;
        }
        public async Task <IActionResult> AllWorkAttachments()
        {
            
            return View(await Attachrepo.AllAttachments());
        }    
        public async Task <JsonResult> AttachmentSearch(string Search)
        {
            var query = await Attachrepo.SearchAttachment(Search);
            return Json(query);
        }  
        public async Task <FileResult> AttachmentView(int Id)
        {
            var file = await Attachrepo.WrokAttachmentView(Id);
            return File(file.File, file.ContentType);
        }  
      
    }
}
