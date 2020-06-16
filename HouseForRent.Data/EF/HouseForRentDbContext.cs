using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.EF
{
    public class HouseForRentDbContext : DbContext
    {
        public HouseForRentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentType> ApartmentTypes { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetRent> AssetRents { get; set; }
        public DbSet<AssetRentStatus> AssetRentStatuses { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractDuration> ContractDurations { get; set; }
        public DbSet<ContractStatus> ContractStatuses { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customer_Apartment> Customers_Apartments { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Motorbike> Motorbikes { get; set; }
        public DbSet<MotorType> MotorTypes { get; set; }
        public DbSet<PowerIndexManagement> PowerIndexManagements { get; set; }
        public DbSet<PowerPrice> PowerPrice { get; set; }
        public DbSet<RepairRequest> RepairRequests { get; set; }
        public DbSet<RepairRequestStatus> RepairRequestStatuses { get; set; }
        public DbSet<SewagePrice> SewagePrice { get; set; }
        public DbSet<SupplyPrice> SupplyPrice { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<VisitorManagement> VisitorManagements { get; set; }
        public DbSet<WaterIndexManagement> WaterIndexManagements { get; set; }
    }
}
