using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.BaseEntity.BaseTypeEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.AssetTypes.Commands
{
    public class CreateAssetTypeCommand : BaseCreateTypeEntityCommand, IRequest<Response>
    {
    }
}
