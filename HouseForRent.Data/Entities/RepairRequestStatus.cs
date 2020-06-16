using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class RepairRequestStatus
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public List<RepairRequest> RepairRequests { get; set; }
    }
}
