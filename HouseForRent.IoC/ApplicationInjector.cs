using AutoMapper;
using HouseForRent.Application.MappingConfigs;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HouseForRent.IoC
{
    public class ApplicationInjector
    {
        public static void Register(IServiceCollection services)
        {
            //Application
            var mappingConfig = AutoMapping.RegisterMappings();
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            // Domain - Commands
            var serviceDependencies = Assembly.Load("HouseForRent.Application").GetTypes().Where(x => x.IsClass && x.Name.EndsWith("Service"));
            foreach (var serviceDependency in serviceDependencies)
            {
                var type = serviceDependency.GetInterfaces().FirstOrDefault();
                services.AddScoped(type, serviceDependency);
            }
        }
    }
}
