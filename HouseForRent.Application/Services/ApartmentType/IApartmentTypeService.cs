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
        Task<Response> CreateUpdateApartmentType(CreateUpdateApartmentTypeViewModel createUpdateApartmentTypeViewModel);
        Task<Response> DeleteApartmentType(DeleteApartmentTypeViewModel deleteApartmentTypeViewModel);
        Task<List<ApartmentTypeDTO>> GetAllApartmentType();
        Task<Response> GetApartmentType(GetApartmentTypeViewModel getApartmentTypeViewModel);
    }
}
