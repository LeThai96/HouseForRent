﻿using HouseForRent.DomainCore.MediatR;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.AparmentTypes.Commands
{
    public class DeleteApartmentTypeCommand : IRequest<Response>
    {
        public Guid Id { get; set; }
    }
}
