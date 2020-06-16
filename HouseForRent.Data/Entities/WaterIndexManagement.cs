using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class WaterIndexManagement
    {
        public Guid Id { get; set; }
        public Guid AparmentId { get; set; }
        public double StartIndex { get; set; }
        public double EndIndex { get; set; }
        public double SupplyPrice { get; set; }
        public double SewagePrice { get; set; }
        public DateTime Period { get; set; }
    }
}
