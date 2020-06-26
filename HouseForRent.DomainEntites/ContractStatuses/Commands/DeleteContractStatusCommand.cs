using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.BaseEntity.BaseStatusEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.ContractStatuses.Commands
{
    public class DeleteContractStatusCommand : BaseDeleteStatusEntityCommand, IRequest<Response>
    {
    }
}
