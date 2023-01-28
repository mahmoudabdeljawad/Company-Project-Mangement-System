using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Entity
{
    public class TeamMember :Member
    {
        public List<Duty> Duties { get; set; }
    }
}
