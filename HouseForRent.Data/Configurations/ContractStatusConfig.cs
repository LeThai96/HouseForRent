using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class ContractStatusConfig : IEntityTypeConfiguration<ContractStatus>
    {
        public void Configure(EntityTypeBuilder<ContractStatus> builder)
        {
            builder.ToTable("ContractStatuses");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Status).HasMaxLength(50);
            builder.Property(o => o.Description).HasMaxLength(500);
        }
    }
}
