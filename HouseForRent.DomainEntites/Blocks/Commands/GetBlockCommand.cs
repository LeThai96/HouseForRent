using HouseForRent.DomainCore.MediatR;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.Blocks.Commands
{
    public class GetBlockCommand : IRequest<Response>
    {
        public string BlockName { get; set; }
    }
}
