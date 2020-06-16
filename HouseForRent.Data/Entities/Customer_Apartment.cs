using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Customer_Apartment
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
