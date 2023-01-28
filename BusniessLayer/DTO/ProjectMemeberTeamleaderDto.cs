using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.DTO
{
    public class ProjectMemeberTeamleaderDto
    {
        public string Id { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }


    }
}
