using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    class RepairRequestConfig : IEntityTypeConfiguration<RepairRequest>
    {
        public void Configure(EntityTypeBuilder<RepairRequest> builder)
        {
            builder.ToTable("RepairRequests");
            builder.HasKey(o => o.Id);

            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(500);

            builder.HasOne(x => x.Apartment).WithMany(x => x.RepairRequests)
                .IsRequired();
            builder.HasOne(x => x.Status).WithMany(x => x.RepairRequests)
                .IsRequired();
        }
    }
}
