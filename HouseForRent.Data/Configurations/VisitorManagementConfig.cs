using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class VisitorManagementConfig : IEntityTypeConfiguration<VisitorManagement>
    {
        public void Configure(EntityTypeBuilder<VisitorManagement> builder)
        {
            builder.ToTable("VisitorManagements");
            builder.HasKey(o => o.Id);

            builder.Property(x => x.DateCheckIn).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(500);

            builder.HasOne(x => x.Apartment).WithMany(x => x.VisitorManagements)
                .IsRequired();
            builder.HasOne(x => x.Customer).WithMany(x => x.VisitorManagements)
                .IsRequired();
        }
    }
}
