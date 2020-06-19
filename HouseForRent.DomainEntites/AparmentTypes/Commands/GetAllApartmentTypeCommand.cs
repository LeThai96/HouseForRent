using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AparmentTypes.DTOs;
using HouseForRent.DomainEntities.BaseEntity.BaseTypeEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.AparmentTypes.Commands
{
    public class GetAllApartmentTypeCommand : BaseGetAllTypeEntityCommand, IRequest<Response>
    {
    }
}
