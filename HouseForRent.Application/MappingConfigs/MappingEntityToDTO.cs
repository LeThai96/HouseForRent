using AutoMapper;
using HouseForRent.Data.Entities;
using HouseForRent.DomainEntities.AparmentTypes.DTOs;
using HouseForRent.DomainEntities.Blocks.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Application.MappingConfigs
{
    public class MappingEntityToDTO: Profile
    {
        public MappingEntityToDTO()
        {
            CreateMap<ApartmentType, ApartmentTypeDTO>();
            CreateMap<Block, BlockDTO>();
        }
    }
}
