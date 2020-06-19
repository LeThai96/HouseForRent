using AutoMapper;
using HouseForRent.Application.MappingConfigs;
using Microsoft.AspNetCore.Http;
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
