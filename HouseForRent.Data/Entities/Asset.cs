using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public AssetType AssetType { get; set; }
        public Unit Unit { get; set; }
        public double VAT { get; set; }
        public int Instock { get; set; }
        public string Note { get; set; }
        public Block Block { get; set; }

        public List<AssetRent> AssetRents { get; set; }
    }
}
