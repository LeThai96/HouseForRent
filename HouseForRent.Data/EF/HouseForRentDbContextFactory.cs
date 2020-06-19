using HouseForRent.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.EF
{
    public class HouseForRentDbContextFactory : IDesignTimeDbContextFactory<HouseForRentDbContext>
    {
        public HouseForRentDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<HouseForRentDbContext>();
            optionBuilder.UseSqlServer(ConfigConstants.ConnectionString);
            return new HouseForRentDbContext(optionBuilder.Options);
        }
    }
}
