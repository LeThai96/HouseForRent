using HouseForRent.DomainCore.MediatR;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.Blocks.Commands
{
    public class UpdateBlockCommand : IRequest<Response>
    {
        public Guid Id { get; set; }
        public string BlockName { get; set; }
        public string Description { get; set; }
    }
}
