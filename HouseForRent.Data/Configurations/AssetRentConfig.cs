using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class AssetRentConfig : IEntityTypeConfiguration<AssetRent>
    {
        public void Configure(EntityTypeBuilder<AssetRent> builder)
        {
            builder.ToTable("AssetRents");
            builder.HasKey(o => o.Id);

            builder.Property(x => x.DateRecevice).IsRequired();
            builder.Property(x => x.DatePayback).IsRequired();
            builder.Property(x => x.Count).IsRequired().HasDefaultValue(1);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(500);

            builder.HasOne(x => x.Asset).WithMany(x => x.AssetRents)
                .IsRequired();
            builder.HasOne(x => x.Customer).WithMany(x => x.AssetRents)
                .IsRequired();
            builder.HasOne(x => x.AssetRentStatus).WithMany(x => x.AssetRents)
                .IsRequired();
        }
    }
}
