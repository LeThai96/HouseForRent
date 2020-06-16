using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerType>().HasData(
                new CustomerType() { Type = "Base", Description = "Base" }
                );
            modelBuilder.Entity<ApartmentType>().HasData(
                new ApartmentType() { Type = "Base", Description = "Base" }
                );
            modelBuilder.Entity<AssetType>().HasData(
                new AssetType() { Type = "Base", Description = "Base" }
                );
            modelBuilder.Entity<Unit>().HasData(
                new Unit() { UnitName = "Base", Description = "Base" }
                );
            modelBuilder.Entity<Block>().HasData(
               new Block() { BlockName = "Base", Description = "Base" }
               );
            modelBuilder.Entity<AssetRentStatus>().HasData(
               new AssetRentStatus() { Status = "Base", Description = "Base" }
               );
            modelBuilder.Entity<MotorType>().HasData(
               new MotorType() { Type = "Base", Description = "Base" }
               );
            modelBuilder.Entity<ContractType>().HasData(
               new ContractType() { Type = "Base", Description = "Base" }
               );
            modelBuilder.Entity<ContractDuration>().HasData(
               new ContractDuration() { Duration = "3 tháng", Description = "3 tháng" },
               new ContractDuration() { Duration = "6 tháng", Description = "6 tháng" },
               new ContractDuration() { Duration = "1 năm", Description = "1 năm" }
               );
            modelBuilder.Entity<ContractStatus>().HasData(
               new ContractStatus() { Status = "Base", Description = "Base" }
               );
            modelBuilder.Entity<RepairRequestStatus>().HasData(
               new RepairRequestStatus() { Status = "Base", Description = "Base" }
               );
        }
    }
}
