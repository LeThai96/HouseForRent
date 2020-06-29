using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.BaseEntity.BaseTypeEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.CustomerTypes.Commands
{
    public class UpdateCustomerTypeCommand : BaseUpdateTypeEntityCommand, IRequest<Response>
    {

    }
}
