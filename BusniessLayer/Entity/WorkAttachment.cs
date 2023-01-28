using System;
using System.Collections.Generic;

namespace BusniessLayer.Entity
{
    public class WorkAttachment
    {
        public int WorkAttachmentId { set; get; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public  Byte[] File { get; set; }
        public Work Works { get; set; }
        public int WorkId { get; set; }
        public List<WorkHistory> WorkHistories { get; set; }
    }
}
