using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Entity
{
   public class WorkHistory
    {
        public int Id { get; set; }
        public Work Work { get; set; }
        public int WorkId { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
        public DateTime UpdateTime { get; set; }
        public List<Reject> Rejects { get; set; }
        public WorkAttachment WorkAttachments  { get; set; }
        public int WorkAttachmentId { get; set; }
    }
}
