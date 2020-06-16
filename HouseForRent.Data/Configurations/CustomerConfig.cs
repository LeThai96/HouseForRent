using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Gender).IsRequired();
            builder.Property(t => t.PhoneNumber).IsRequired().HasMaxLength(20);
            builder.Property(t => t.IdentityCardNumber).IsRequired().HasMaxLength(20);
            builder.Property(t => t.IdentityCardPlaceIssue).HasMaxLength(100);
            builder.Property(t => t.Address).HasMaxLength(100);
            builder.Property(t => t.CardNumber).HasMaxLength(20);
            builder.Property(t => t.Bank).HasMaxLength(100);
            builder.Property(t => t.Email).HasMaxLength(50);
            builder.Property(t => t.Note).HasMaxLength(500);

            builder.HasOne(x => x.CustomerType).WithMany(x => x.Customers)
                .IsRequired();
        }
    }
}
