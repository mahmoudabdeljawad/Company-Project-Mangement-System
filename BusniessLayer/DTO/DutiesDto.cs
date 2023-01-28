using BusniessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.DTO
{
   public class DutiesDto:Duty
    {
        public String MemberId { get; set; }
        public string RoleName { get; set; }
        public string UserName { get; set; }
        public string SprintName { get; set; }
    }
}
