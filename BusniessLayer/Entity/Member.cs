using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusniessLayer.Entity
{
    public class Member : IdentityUser
    {
        public string FitstName { get; set; }
        public string LastName { get; set; }

        public Band Band { get; set; }
        public int BandId { get; set; }
        public List<ProjectMembers> ProjectMembers { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        public string ImageUrl { get; set; }
        public List<Comment> Comments { get; set; }
    }
}