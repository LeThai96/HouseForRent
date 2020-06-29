using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class MotorbikeConfig : IEntityTypeConfiguration<Motorbike>
    {
        public void Configure(EntityTypeBuilder<Motorbike> builder)
        {
            builder.ToTable("Motorbikes");
            builder.HasKey(o => o.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.MotorNumber).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.Customer).WithMany(x => x.Motorbikes)
                .IsRequired();
            builder.HasOne(x => x.MotorType).WithMany(x => x.Motorbikes)
                .IsRequired();
        }
    }
}
