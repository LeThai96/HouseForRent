using HouseForRent.DomainCore.MediatR;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.Units.Commands
{
    public class DeleteUnitCommand : IRequest<Response>
    {
        public Guid Id { get; set; }
    }
}
