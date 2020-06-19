using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.CustomerTypes.Commands;
using HouseForRent.DomainEntities.CustomerTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.CustomerTypes.CommandHandlers
{
    public class GetAllCustomerTypesCommandHandler : IRequestHandler<GetAllCustomerTypesCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllCustomerTypesCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(GetAllCustomerTypesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbCustomerTypes = await _unitOfWork.Repository<CustomerType>().FindAll();

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = dbCustomerTypes.Select(x => new CustomerTypeDTO()
                    {
                        Type = x.Type,
                        Description = x.Description
                    }).ToList()
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
