using HouseForRent.Application.Models.ApartmentType;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AparmentTypes.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HouseForRent.Application.Services.ApartmentType
{
    public interface IApartmentTypeService
    {
        Task<Response> CreateApartmentType(CreateApartmentTypeViewModel model);
        Task<Response> UpdateApartmentType(UpdateApartmentTypeViewModel model);
        Task<Response> DeleteApartmentType(DeleteApartmentTypeViewModel model);
        Task<Response> GetAllApartmentType(GetAllApartmentTypesViewModel model);
        Task<Response> GetApartmentType(GetApartmentTypeViewModel model);
    }
}
