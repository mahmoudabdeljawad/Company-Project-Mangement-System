using BusniessLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusniessLayer.DTO
{
    public class CreateProjectDto 
    {
        [Required]

        public int ProjectId { get; set; }
        [Required]

        public string ProjectName { get; set; }
        [Required]

        public string Descrption { get; set; }
        [Required]

        public DateTime Deadline { get; set; }
        [Required]

        public string TeamLeaderId { get; set; }
        [Required]

        public List<string> ProjectMemberId { get; set; }
    }
}
