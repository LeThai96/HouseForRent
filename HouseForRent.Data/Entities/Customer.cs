using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CustomerType { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string IdentityCardNumber { get; set; }
        public DateTime IdentityCardDateIssue { get; set; }
        public string IdentityCardPlaceIssue { get; set; }
        public string Adress { get; set; }
        public string CardNumber { get; set; }
        public string Bank { get; set; }
        public string ProfileImage { get; set; }
        public string Note { get; set; }
    }
}
