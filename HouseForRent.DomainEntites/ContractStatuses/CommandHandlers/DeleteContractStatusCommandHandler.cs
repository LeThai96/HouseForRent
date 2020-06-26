using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.ContractStatuses.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.ContractStatuses.CommandHandlers
{
    public class DeleteContractStatusCommandHandler : IRequestHandler<DeleteContractStatusCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteContractStatusCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(DeleteContractStatusCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbContractStatus = await _unitOfWork.Repository<ContractStatus>().FindByPK(request.Id);
                if (dbContractStatus != null)
                {
                    _unitOfWork.Repository<ContractStatus>().Delete(dbContractStatus);
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
