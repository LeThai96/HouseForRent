using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    class SupplyWaterPriceConfig : IEntityTypeConfiguration<SupplyPrice>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SupplyPrice> builder)
        {
            builder.ToTable("SupplyPrice");
            builder.HasKey(o => o.PricePerM3);
            builder.Property(o => o.PricePerM3).HasDefaultValue(0);
        }
    }
}
