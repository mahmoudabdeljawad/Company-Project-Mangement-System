using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Entity
{
    public class Comment
    {
        public int Commentid { get; set; }
        public string CommentText { get; set; }
        public DateTime dateTime { get; set; }
        public Project project { get; set; }
        public int? ProjectId { get; set; }
        public Member Member { get; set; }
        public string MemberId { get; set; }
    }
}