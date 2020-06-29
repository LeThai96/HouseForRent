using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.CustomerTypes.DTOs
{
    public class CustomerTypeDTO
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
