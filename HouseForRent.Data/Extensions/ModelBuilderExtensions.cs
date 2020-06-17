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
                new CustomerType() { Id= Guid.NewGuid(), Type = "Base", Description = "Base" }
                );
            modelBuilder.Entity<ApartmentType>().HasData(
                new ApartmentType() { Id = Guid.NewGuid(), Type = "Base", Description = "Base" }
                );
            modelBuilder.Entity<AssetType>().HasData(
                new AssetType() { Id = Guid.NewGuid(), Type = "Base", Description = "Base" }
                );
            modelBuilder.Entity<Unit>().HasData(
                new Unit() { Id = Guid.NewGuid(), UnitName = "Base", Description = "Base" }
                );
            modelBuilder.Entity<Block>().HasData(
               new Block() {Id= Guid.NewGuid(), BlockName = "Base", Description = "Base" }
               );
            modelBuilder.Entity<AssetRentStatus>().HasData(
               new AssetRentStatus() { Id = Guid.NewGuid(), Status = "Base", Description = "Base" }
               );
            modelBuilder.Entity<MotorType>().HasData(
               new MotorType() { Id = Guid.NewGuid(), Type = "Base", Description = "Base" }
               );
            modelBuilder.Entity<ContractType>().HasData(
               new ContractType() { Id = Guid.NewGuid(), Type = "Base", Description = "Base" }
               );
            modelBuilder.Entity<ContractDuration>().HasData(
               new ContractDuration() { Id = Guid.NewGuid(), Duration = "3 tháng", Description = "3 tháng" },
               new ContractDuration() { Id = Guid.NewGuid(), Duration = "6 tháng", Description = "6 tháng" },
               new ContractDuration() { Id = Guid.NewGuid(), Duration = "1 năm", Description = "1 năm" }
               );
            modelBuilder.Entity<ContractStatus>().HasData(
               new ContractStatus() { Id = Guid.NewGuid(), Status = "Base", Description = "Base" }
               );
            modelBuilder.Entity<RepairRequestStatus>().HasData(
               new RepairRequestStatus() { Id = Guid.NewGuid(), Status = "Base", Description = "Base" }
               );
        }
    }
}
