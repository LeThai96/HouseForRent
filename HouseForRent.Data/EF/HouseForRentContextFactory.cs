using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.EF
{
    public class HouseForRentContextFactory : IDesignTimeDbContextFactory<HouseForRentDbContext>
    {
        public HouseForRentDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<HouseForRentDbContext>();
            optionBuilder.UseSqlServer("Data Source=ADMIN;Initial Catalog=HouseForRent;User ID=admin;Password=1234");
            return new HouseForRentDbContext(optionBuilder.Options);
        }
    }
}
