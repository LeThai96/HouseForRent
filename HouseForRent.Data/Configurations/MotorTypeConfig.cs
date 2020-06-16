using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class MotorTypeConfig : IEntityTypeConfiguration<MotorType>
    {
        public void Configure(EntityTypeBuilder<MotorType> builder)
        {
            builder.ToTable("MotorTypes");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Type).HasMaxLength(50);
            builder.Property(o => o.Description).HasMaxLength(500);
        }
    }
}
