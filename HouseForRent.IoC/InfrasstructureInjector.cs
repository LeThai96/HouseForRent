using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.EF;
using HouseForRent.DomainCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.IoC
{
    public class InfrasstructureInjector
    {
        public static void Register(IServiceCollection services)
        {
            services.AddDbContext<HouseForRentDbContext>(option => option.UseSqlServer(ConfigConstants.ConnectionString));

            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        }
    }
}
