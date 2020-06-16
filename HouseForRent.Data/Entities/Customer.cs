using HouseForRent.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CustomerType CustomerType { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public string IdentityCardNumber { get; set; }
        public DateTime IdentityCardDateIssue { get; set; }
        public string IdentityCardPlaceIssue { get; set; }
        public string Adress { get; set; }
        public string CardNumber { get; set; }
        public string Bank { get; set; }
        public string ProfileImage { get; set; }
        public string Note { get; set; }

        public List<Customer_Apartment> Customers_Apartments { get; set; }
        public List<AssetRent> AssetRents { get; set; }
        public List<VisitorManagement> VisitorManagements { get; set; }
        public List<Motorbike> Motorbikes { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
