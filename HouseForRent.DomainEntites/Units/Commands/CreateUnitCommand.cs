using HouseForRent.DomainCore.MediatR;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.Units.Commands
{
    public class CreateUnitCommand: IRequest<Response>
    {
        public string UnitName { get; set; }
        public string Description { get; set; }
    }
}
