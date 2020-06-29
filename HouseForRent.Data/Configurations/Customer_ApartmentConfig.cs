using HouseForRent.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Configurations
{
    public class Customer_ApartmentConfig : IEntityTypeConfiguration<Customer_Apartment>
    {
        public void Configure(EntityTypeBuilder<Customer_Apartment> builder)
        {
            builder.ToTable("Customers_Apartments");
            builder.HasKey(x => new { x.CustomerId, x.ApartmentId });
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Customers_Apartments)
                .HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Apartment)
            .WithMany(x => x.Customers_Apartments)
            .HasForeignKey(x => x.ApartmentId);
        }
    }
}
