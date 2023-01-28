using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Entity
{
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public List<Work> Works { get; set; }
        public List<Duty> duties { get; set; }
        public List<Sprint> sprints { get; set; }
        public List<WorkHistory> WorkHistories { get; set; }
        public List<Project> Projects { get; set; }
        public List<LastUpdate> LastUpdates { get; set; }
    }
}