using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusniessLayer.Entity
{
    public class Sprint
    {

        public int SprintId { get; set; }
        [Required]
        public string SprintName { get; set; }
        [Required]

        public string sprintDescrption { get; set; }
        [Required]

        public DateTime StartDate { get; set; }
        [Required]

        public DateTime EndDate { get; set; }
        [Required]

        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public State State { get; set; } 
        public int StateId { get; set; }
        public List<Duty> Duties { get; set; }



    }
}
