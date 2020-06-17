using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class PowerIndexManagementConfig : IEntityTypeConfiguration<PowerIndexManagement>
    {
        public void Configure(EntityTypeBuilder<PowerIndexManagement> builder)
        {
            builder.ToTable("PowerIndexManagements");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.StartIndex).IsRequired();
            builder.Property(o => o.EndIndex).IsRequired();
            builder.Property(o => o.PowerPrice).IsRequired();
            builder.Property(o => o.Period).IsRequired();

            builder.HasOne(x => x.Apartment).WithMany(x => x.PowerIndexManagements)
                .IsRequired();
        }
    }
}
