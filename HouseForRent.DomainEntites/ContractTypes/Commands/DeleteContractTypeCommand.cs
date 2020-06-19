using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.BaseEntity.BaseTypeEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.ContractTypes.Commands
{
    public class DeleteContractTypeCommand : BaseDeleteTypeEntityCommand, IRequest<Response>
    {
    }
}
