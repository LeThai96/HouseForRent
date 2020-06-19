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
    public class UpdateCustomerTypeCommandHandler : IRequestHandler<UpdateCustomerTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCustomerTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateCustomerTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbCustomerType = await _unitOfWork.Repository<CustomerType>().FindOne(x => x.Id == request.Id);
                if (dbCustomerType != null)
                {
                    dbCustomerType.Type = request.Type;
                    dbCustomerType.Description = request.Description;
                    _unitOfWork.Repository<CustomerType>().Update(dbCustomerType);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<CustomerTypeDTO>(dbCustomerType)
                    });
                }

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.DataNotExist.Key,
                    Message = ErrorCodeMessage.DataNotExist.Value,
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
