using AutoMapper;
using HouseForRent.Application.Models.ApartmentType;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AparmentTypes.Commands;
using HouseForRent.DomainEntities.AparmentTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HouseForRent.Application.Services.ApartmentType
{
    public class ApartmentTypeService : IApartmentTypeService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ApartmentTypeService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<Response> CreateUpdateApartmentType(CreateUpdateApartmentTypeViewModel createUpdateApartmentTypeViewModel)
        {
            var createUpdateApartmentTypeCommand = _mapper.Map<CreateUpdateApartmentTypeCommand>(createUpdateApartmentTypeViewModel);
            return await _mediator.Send(createUpdateApartmentTypeCommand);
        }

        public async Task<Response> DeleteApartmentType(DeleteApartmentTypeViewModel deleteApartmentTypeViewModel)
        {
            var deleteApartmentTypeCommand = _mapper.Map<DeleteApartmentTypeCommand>(deleteApartmentTypeViewModel);
            return await _mediator.Send(deleteApartmentTypeCommand);
        }

        public async Task<List<ApartmentTypeDTO>> GetAllApartmentType()
        {
            var getAllApartmentTypeCommand = _mapper.Map<GetAllApartmentTypeCommand>(null);
            return await _mediator.Send(getAllApartmentTypeCommand);
        }

        public async Task<Response> GetApartmentType(GetApartmentTypeViewModel getApartmentTypeViewModel)
        {
            var getApartmentTypeCommand = _mapper.Map<GetApartmentTypeCommand>(getApartmentTypeViewModel);
            return await _mediator.Send(getApartmentTypeCommand);
        }
    }
}
