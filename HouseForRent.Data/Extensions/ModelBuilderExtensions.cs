using HouseForRent.Data.Entities;
using Microsoft.AspNetCore.Identity;
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

            var ADMIN_ID = new Guid("023D8B3F-A56B-4A12-92E1-B066210CD854");
            var MANAGER_ID = new Guid("2A222ED2-FC1D-4CD2-96E1-CCA3F08DB5F6");
            var MANAGER_ROLE_ID = new Guid("EC2D3359-98C7-4CE8-A1BF-33345E7E3424");
            var ADMIN_ROLE_ID = new Guid("9BF83243-05E6-4F30-A591-AB1E35E0BD91");

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = ADMIN_ROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            }, new AppRole
            {
                Id = MANAGER_ROLE_ID,
                Name = "manager",
                NormalizedName = "manager"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "le.dinhthai00@gmail.com",
                NormalizedEmail = "le.dinhthai00@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin1234$"),
                SecurityStamp = string.Empty
            }, new AppUser
            {
                Id = MANAGER_ID,
                UserName = "manager",
                NormalizedUserName = "manager",
                Email = "le.dinhthai00@gmail.com",
                NormalizedEmail = "le.dinhthai00@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Manager1234$"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            }, new IdentityUserRole<Guid>
            {
                RoleId = MANAGER_ROLE_ID,
                UserId = MANAGER_ID
            });
        }
    }
}
