using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.BaseEntity.BaseStatusEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.AssetRentStatuses.Commands
{
    public class UpdateAssetRentStatusCommand : BaseUpdateStatusEntityCommand, IRequest<Response>
    {
    }
}
