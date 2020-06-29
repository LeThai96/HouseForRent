using HouseForRent.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class Apartment
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public ApartmentType ApartmentType { get; set; }
        public Block Block { get; set; }
        public int Floor { get; set; }
        public int Capacity { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public double Deposite { get; set; }
        public ApartmentStatus Status { get; set; }
        public string Note { get; set; }

        public List<Customer_Apartment> Customers_Apartments { get; set; }
        public List<VisitorManagement> VisitorManagements { get; set; }
        public List<PowerIndexManagement> PowerIndexManagements { get; set; }
        public List<WaterIndexManagement> WaterIndexManagements { get; set; }
        public List<Contract> Contracts { get; set; }
        public List<RepairRequest> RepairRequests { get; set; }
    }
}
