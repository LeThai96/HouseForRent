using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class WaterIndexManagementConfig : IEntityTypeConfiguration<WaterIndexManagement>
    {
        public void Configure(EntityTypeBuilder<WaterIndexManagement> builder)
        {
            builder.ToTable("WaterIndexManagements");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.StartIndex).IsRequired();
            builder.Property(o => o.EndIndex).IsRequired();
            builder.Property(o => o.SupplyPrice).IsRequired();
            builder.Property(o => o.SewagePrice).IsRequired();
            builder.Property(o => o.Period).IsRequired();

            builder.HasOne(x => x.Apartment).WithMany(x => x.WaterIndexManagements)
                .IsRequired();
        }
    }
}
