using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Unit
    {
        public Guid Id { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }

        public List<Asset> Assets { get; set; }
    }
}
