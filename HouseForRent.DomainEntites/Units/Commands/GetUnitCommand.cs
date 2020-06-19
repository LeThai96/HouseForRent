using HouseForRent.DomainCore.MediatR;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.Units.Commands
{
    public class GetUnitCommand : IRequest<Response>
    {
        public string UnitName { get; set; }
    }
}
