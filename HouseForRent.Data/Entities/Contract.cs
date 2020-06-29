using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Contract
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public Apartment Apartment { get; set; }
        public ContractType ContractType { get; set; }
        public ContractDuration Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public double Deposit { get; set; }
        public string RentAssets { get; set; }
        public string RentServices { get; set; }
        public ContractStatus Status { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
    }
}
