using BusniessLayer.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLayer.Repository
{
    public interface IWorkAttacRepository
    {
        void AddWorkAttachments(IFormFile File, int WorkId);
        Task<List<WorkAttachment>> AllAttachments();
        Task<List<WorkAttachmentDto>> SearchAttachment(string Search);

        //​
        //        Task<List<WorkAttachment>> Workattachment(int WorkId);
        //        Task<WorkAttachment> Workattachmentd(int WorkId);
        Task<List<WorkAttachment>> Workattachment(int WorkId);
        Task<WorkAttachment> Workattachmentd(int WorkId);
        Task<WorkAttachment> WrokAttachmentHistory(int WorkAttachmentId);
        Task<WorkAttachment> WrokAttachmentView(int WorkAttachmentId);
    }
}
