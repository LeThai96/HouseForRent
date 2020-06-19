using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.Units.DTOs
{
    public class UnitDTO
    {
        public Guid Id { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }
    }
}
