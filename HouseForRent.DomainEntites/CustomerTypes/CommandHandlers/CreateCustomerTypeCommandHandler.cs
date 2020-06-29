using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.CustomerTypes.Commands;
using HouseForRent.DomainEntities.CustomerTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.CustomerTypes.CommandHandlers
{
    public class CreateCustomerTypeCommandHandler : IRequestHandler<CreateCustomerTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCustomerTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(CreateCustomerTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbCustomerType = await _unitOfWork.Repository<CustomerType>().FindOne(x => x.Type == request.Type);

                if (dbCustomerType == null)
                {
                    var customerType = new CustomerType()
                    {
                        Type = request.Type,
                        Description = request.Description
                    };
                    _unitOfWork.Repository<CustomerType>().Insert(customerType);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<CustomerTypeDTO>(customerType)
                    });
                }

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.IdentityDuplicate.Key,
                    Message = ErrorCodeMessage.IdentityDuplicate.Value,
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
