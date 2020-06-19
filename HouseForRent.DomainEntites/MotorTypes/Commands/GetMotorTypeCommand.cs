using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.BaseEntity.BaseTypeEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.MotorTypes.Commands
{
    public class GetMotorTypeCommand : BaseGetTypeEntityCommand, IRequest<Response>
    {
    }
}
