using AutoMapper;
using HouseForRent.Application.Models.ApartmentType;
using HouseForRent.DomainEntities.AparmentTypes.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Application.MappingConfigs
{
    public class MappingViewModelToCommand: Profile
    {
        public MappingViewModelToCommand()
        {
            CreateMap<GetApartmentTypeViewModel, GetApartmentTypeCommand>();
            CreateMap<GetAllApartmentTypesViewModel, GetAllApartmentTypeCommand>();
            CreateMap<CreateApartmentTypeViewModel, CreateApartmentTypeCommand>();
            CreateMap<UpdateApartmentTypeViewModel, UpdateApartmentTypeCommand>();
            CreateMap<DeleteApartmentTypeViewModel, DeleteApartmentTypeCommand>();
        }
    }
}
