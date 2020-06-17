using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class PowerPriceConfig : IEntityTypeConfiguration<PowerPrice>
    {
        public void Configure(EntityTypeBuilder<PowerPrice> builder)
        {
            builder.ToTable("PowerPrice");
            builder.HasKey(o => o.PricePerKw);
            builder.Property(o => o.PricePerKw).HasDefaultValue(0);
        }
    }
}
