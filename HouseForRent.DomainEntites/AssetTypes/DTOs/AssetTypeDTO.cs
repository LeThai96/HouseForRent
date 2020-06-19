using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.AssetTypes.DTOs
{
    public class AssetTypeDTO
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
