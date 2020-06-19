using HouseForRent.DomainCore.MediatR;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.Blocks.Commands
{
    public class DeleteBlockCommand : IRequest<Response>
    {
        public Guid Id { get; set; }
    }
}
