using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class MotorType
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public List<Motorbike> Motorbikes { get; set; }
    }
}
