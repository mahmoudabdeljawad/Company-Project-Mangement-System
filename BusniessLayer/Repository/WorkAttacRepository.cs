using BusniessLayer.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BusniessLayer.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace BusniessLayer.Repository
{
    public class WorkAttacRepository : IWorkAttacRepository
    {
        private readonly ApplicationDbContext Context;
        public WorkAttacRepository(ApplicationDbContext Context)
        {
            this.Context = Context;
        }
        public async Task <List<WorkAttachment>> AllAttachments()
        {
            return await Context.WorkAttachments.Include(x => x.Works).ToListAsync();
        }  
        public async Task <List<WorkAttachmentDto>> SearchAttachment(string Search)
        {
            var query = await (from wa in Context.WorkAttachments
                               join w in Context.Works on wa.WorkId equals w.WorkId
                               select new WorkAttachmentDto { WorkAttachmentId = wa.WorkAttachmentId,
                                   WorkName = w.WorkName, File = wa.File, FileName = wa.FileName, ContentType = wa.ContentType }
                            ).Where(x=>x.FileName!.Contains(Search)).ToListAsync();
            return query;
        }
        public async Task<List<WorkAttachment>> Workattachment(int WorkId)
        {
            return await (from c in Context.WorkAttachments
                          where c.WorkId == WorkId
                          select c).ToListAsync();
        }
        public async Task<WorkAttachment> Workattachmentd(int WorkId)
        {
            return await (from c in Context.WorkAttachments
                          where c.WorkId == WorkId
                          select c).FirstOrDefaultAsync();
        }   
        public async Task<WorkAttachment> WrokAttachmentHistory(int WorkAttachmentId)
        {
            return await (from c in Context.WorkAttachments
                          where c.WorkAttachmentId == WorkAttachmentId
                          select c).FirstOrDefaultAsync();
        }  
        public async Task<WorkAttachment> WrokAttachmentView(int WorkAttachmentId)
        {
            return await (from c in Context.WorkAttachments
                          where c.WorkAttachmentId == WorkAttachmentId
                          select c).FirstOrDefaultAsync();
        }
        public void AddWorkAttachments(IFormFile File,int WorkId)
        {
            WorkAttachment WA = new WorkAttachment();
            Stream st = File.OpenReadStream();
            using (BinaryReader br = new BinaryReader(st))
            {
                
                WA.WorkId = WorkId;
                WA.FileName = File.FileName;
                WA.ContentType = File.ContentType;
                var bytefile = br.ReadBytes((int)st.Length);
                WA.File = bytefile;
                Context.WorkAttachments.Add(WA);
                Context.SaveChanges();
            }
            var workstate = new WorkHistory()
                {
                    StateId = 3
               ,
                    WorkId = WorkId,
                    UpdateTime = DateTime.Now,
                    WorkAttachmentId=WA.WorkAttachmentId
                };
                Context.WorkHistory.Add(workstate);
                Context.SaveChanges();
           
        }
    }
}

