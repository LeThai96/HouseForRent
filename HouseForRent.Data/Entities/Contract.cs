using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Contract
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ApartmentId { get; set; }
        public string ContractType { get; set; }
        public string Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public double Deposit { get; set; }
        public string RentAssets { get; set; }
        public string RentServices { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
    }
}
