using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusniessLayer.Entity
{
    public class Project
    {
        [Required]
        public int ProjectId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string ProjectDescrption { get; set; }

        [Required]
        public DateTime DeadLine { get; set; }

        public List<ProjectMembers> ProjectMembers { get; set; }
        public List<Sprint> Sprints { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
        public List<Comment> Comments { get; set; }
    }
}