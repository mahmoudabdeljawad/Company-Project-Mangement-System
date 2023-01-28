using BusniessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.DTO
{
     public class WorkDto :Work
    {
        public string UserName { get; set; }
        public string DutiesName { get; set; }
    }
}
