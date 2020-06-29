using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class AssetRent
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public Asset Asset { get; set; }
        public DateTime DateRecevice { get; set; }
        public DateTime DatePayback { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public AssetRentStatus AssetRentStatus { get; set; }
        public string Note { get; set; }
    }
}
