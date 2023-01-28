using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Entity
{
    public class LastUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FieldName { get; set; }
        public DateTime UpdateDate { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
    }
}