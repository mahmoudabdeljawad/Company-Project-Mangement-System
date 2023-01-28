using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.DTO
{
    public class ProjectMangerStateDto
    {
        public string Id { get; set; }
        public string ProjectName { get; set; }
        public string MangerName { get; set; }
        public string MangerLastName { get; set; }
        public DateTime DeadLine { get; set; }
        public int StateId { get; set; }
        public string ImageUrl { get; set; }
    }
}