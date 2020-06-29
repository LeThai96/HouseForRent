using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HouseForRent.IoC
{
    public class DomainInjector
    {
        public static void Register(IServiceCollection services)
        {
            // Domain - Commands
            var handlers = Assembly.Load("HouseForRent.DomainEntities").GetTypes().Where(x => x.IsClass && x.Name.EndsWith("CommandHandler"));
            foreach (var handle in handlers)
            {
                var type = handle.GetInterfaces().FirstOrDefault(x => x.Name.StartsWith("IRequest"));
                services.AddScoped(type, handle);
            }
        }
    }
}
