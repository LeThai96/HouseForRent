using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Block
    {
        public Guid Id { get; set; }
        public string BlockName { get; set; }
        public string Description { get; set; }

        public List<Asset> Assets { get; set; }
        public List<Apartment> Apartments { get; set; }
    }
}
