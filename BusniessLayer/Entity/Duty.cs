using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusniessLayer.Entity
{
    public class Duty
    {
        public int DutyId { get; set; }
        [Required]

        public string DutyName { get; set; }
        [Required]

        public string DutyDescrption { get; set; }
        

        public Sprint Sprint { get; set; }
        public int SprintId { get; set; }
        [Required]

        public TeamMember TeamMember { get; set; }
        [Required]

        public string TeamMemberId { get; set; }
        public List<Work> Works { get; set; }
        public State State { get; set; }  
        public int StateId { get; set; }


    }
}
