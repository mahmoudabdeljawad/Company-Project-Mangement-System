using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusniessLayer.Entity
{
    public class Work
    {
        public int WorkId { get; set; }
        [Required]
        public string WorkName { get; set; }
        [Required]

        public string WorkDescrption { get; set; }

        public Duty Duty { get; set; }
        public int DutyId { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }

        public List<WorkAttachment> WorkAttachments { get; set; }
        public List<WorkHistory> WorkHistories { get; set; }
        public List<Reject> Rejects { get; set; }
    }
}
