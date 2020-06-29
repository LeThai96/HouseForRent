using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.CustomerTypes.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.CustomerTypes.CommandHandlers
{
    public class DeleteCustomerTypeCommandHandler : IRequestHandler<DeleteCustomerTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCustomerTypeCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(DeleteCustomerTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbCustomerType = await _unitOfWork.Repository<CustomerType>().FindByPK(request.Id);
                if (dbCustomerType != null)
                {
                    _unitOfWork.Repository<CustomerType>().Delete(dbCustomerType);
                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
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
