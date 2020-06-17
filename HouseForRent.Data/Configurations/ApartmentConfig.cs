using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class ApartmentConfig : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.ToTable("Apartments");
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Code).IsRequired().HasMaxLength(20).IsUnicode(false);
            builder.Property(t => t.Floor).IsRequired();
            builder.Property(t => t.Price).IsRequired();
            builder.Property(t => t.Note).HasMaxLength(500);

            builder.HasOne(x => x.ApartmentType).WithMany(x => x.Apartments)
                .IsRequired();
            builder.HasOne(x => x.Block).WithMany(x => x.Apartments)
                .IsRequired();
        }
    }
}
