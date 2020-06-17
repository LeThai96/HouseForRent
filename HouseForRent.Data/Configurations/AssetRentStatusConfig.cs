using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class AssetRentStatusConfig : IEntityTypeConfiguration<AssetRentStatus>
    {
        public void Configure(EntityTypeBuilder<AssetRentStatus> builder)
        {
            builder.ToTable("AssetRentStatuses");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Status).HasMaxLength(50);
            builder.Property(o => o.Description).HasMaxLength(500);
        }
    }
}
