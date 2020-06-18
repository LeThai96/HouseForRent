using HouseForRent.DomainEntities.AparmentTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.AparmentTypes.Commands
{
    public class GetAllApartmentTypeCommand : IRequest<List<ApartmentTypeDTO>>
    {
    }
}
