using HouseForRent.DomainCore.MediatR;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.AparmentTypes.Commands
{
    public class GetApartmentType : IRequest<Response>
    {
        public string Type { get; set; }
    }
}
