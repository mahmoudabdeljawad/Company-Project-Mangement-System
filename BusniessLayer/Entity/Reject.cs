using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Entity
{
   public class Reject
    {
        public int Id { get; set; }
        public string RejectedNote { get; set; }
        public DateTime RejectedDate { get; set; }
        public Work Work { get; set; }
        public int WorkId { get; set; }
        public WorkHistory WorkHistory { get; set; }
        public int WorkHistoryId { get; set; }
    }
}
