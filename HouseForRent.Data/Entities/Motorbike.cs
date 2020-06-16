using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Motorbike
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MotorType { get; set; }
        public string MotorNumber { get; set; }
        public Guid CustomerId { get; set; }
    }
}
