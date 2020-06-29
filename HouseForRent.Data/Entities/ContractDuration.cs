using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class ContractDuration
    {
        public Guid Id { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }

        public List<Contract> Contracts { get; set; }
    }
}
