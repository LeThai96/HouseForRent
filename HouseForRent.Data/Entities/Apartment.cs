using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Apartment
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string ApartmentType { get; set; }
        public Guid BlockId { get; set; }
        public int Floor { get; set; }
        public int Capacity { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public double Deposite { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
    }
}
