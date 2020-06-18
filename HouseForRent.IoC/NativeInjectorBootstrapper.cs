using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.IoC
{
    public class NativeInjectorBootstrapper
    {
        public static void Register(IServiceCollection services)
        {
            // Adding dependencies from another layers (isolated from Presentation)
            ApplicationInjector.Register(services);
            DomainInjector.Register(services);
            InfrasstructureInjector.Register(services);
        }
    }
}
