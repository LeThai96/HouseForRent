using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class ContractDurationConfig : IEntityTypeConfiguration<ContractDuration>
    {
        public void Configure(EntityTypeBuilder<ContractDuration> builder)
        {
            builder.ToTable("ContractDurations");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Duration).HasMaxLength(50);
            builder.Property(o => o.Description).HasMaxLength(500);
        }
    }
}
