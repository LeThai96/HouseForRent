using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class RepairRequest
    {
        public Guid Id { get; set; }
        public Apartment Apartment { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RepairRequestStatus Status { get; set; }
    }
}
