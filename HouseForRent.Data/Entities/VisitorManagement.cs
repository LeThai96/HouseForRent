using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class VisitorManagement
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid AparmentId { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }
        public string Note { get; set; }
        public double Price { get; set; }
    }
}
