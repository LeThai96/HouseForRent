using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class AssetConfig : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.ToTable("Assets");
            builder.HasKey(o => o.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.VAT).HasDefaultValue(10);
            builder.Property(x => x.Instock).HasDefaultValue(0);
            builder.Property(x => x.Note).HasMaxLength(500);

            builder.HasOne(x => x.AssetType).WithMany(x => x.Assets)
                .IsRequired();
            builder.HasOne(x => x.Block).WithMany(x => x.Assets)
                .IsRequired();
            builder.HasOne(x => x.Unit).WithMany(x => x.Assets)
                .IsRequired();
        }
    }
}
