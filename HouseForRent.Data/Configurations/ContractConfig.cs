using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class ContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contracts");
            builder.HasKey(o => o.Id);

            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.Deposit).HasDefaultValue(0);
            builder.Property(x => x.RentAssets).HasMaxLength(200);
            builder.Property(x => x.Note).HasMaxLength(500);
            builder.Property(x => x.Description).HasDefaultValue(500);

            builder.HasOne(x => x.Customer).WithMany(x => x.Contracts)
                .IsRequired();
            builder.HasOne(x => x.Apartment).WithMany(x => x.Contracts)
                .IsRequired();
            builder.HasOne(x => x.ContractType).WithMany(x => x.Contracts)
                .IsRequired();
            builder.HasOne(x => x.Duration).WithMany(x => x.Contracts)
                .IsRequired();
            builder.HasOne(x => x.Status).WithMany(x => x.Contracts)
                .IsRequired();
        }
    }
}
