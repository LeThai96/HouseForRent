using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Application.MappingConfigs
{
    public class AutoMapping
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingViewModelToCommand());
            });
        }
    }
}
