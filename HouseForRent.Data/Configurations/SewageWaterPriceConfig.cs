using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class SewageWaterPriceConfig : IEntityTypeConfiguration<SewagePrice>
    {
        public void Configure(EntityTypeBuilder<SewagePrice> builder)
        {
            builder.ToTable("SewagePrice");
            builder.HasKey(o => o.PricePerM3);
            builder.Property(o => o.PricePerM3).HasDefaultValue(0);
        }
    }
}
