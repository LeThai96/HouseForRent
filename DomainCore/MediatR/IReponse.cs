using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainCore.MediatR
{
    public interface IResponse
    {
        int Code { get; set; }
        string Message { get; set; }
    }
}
