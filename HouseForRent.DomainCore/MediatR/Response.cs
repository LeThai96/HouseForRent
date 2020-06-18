using HouseForRent.DomainCore.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainCore.MediatR
{
    public class Response : IResponse
    {
        public Response()
        {
            Message = ErrorCodeMessage.Success.Value;
            Code = ErrorCodeMessage.Success.Key;
        }

        public int Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
