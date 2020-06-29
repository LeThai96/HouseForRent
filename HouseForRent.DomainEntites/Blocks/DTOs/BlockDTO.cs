using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.Blocks.DTOs
{
    public class BlockDTO
    {
        public Guid Id { get; set; }
        public string BlockName { get; set; }
        public string Description { get; set; }
    }
}
