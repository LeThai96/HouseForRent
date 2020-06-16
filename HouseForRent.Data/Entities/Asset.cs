using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AssetType { get; set; }
        public string Unit { get; set; }
        public double VAT { get; set; }
        public int Instock { get; set; }
        public string Note { get; set; }
        public Guid BlockId { get; set; }
    }
}
