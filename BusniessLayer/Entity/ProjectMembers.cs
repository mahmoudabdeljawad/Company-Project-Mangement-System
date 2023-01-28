using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Entity
{
    public class ProjectMembers
    {
        public Member Member { get; set; }
        public string MemberId { get; set; } 
    
        public Project Project { get; set; }
        public int ProjectId { get; set; }
       
    }
}
