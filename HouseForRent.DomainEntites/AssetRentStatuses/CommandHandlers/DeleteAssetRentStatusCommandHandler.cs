using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AssetRentStatuses.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.AssetRentStatuses.CommandHandlers
{
    public class DeleteAssetRentStatusCommandHandler : IRequestHandler<DeleteAssetRentStatusCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteAssetRentStatusCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(DeleteAssetRentStatusCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbAssetRentStatus = await _unitOfWork.Repository<AssetRentStatus>().FindByPK(request.Id);
                if (dbAssetRentStatus != null)
                {
                    _unitOfWork.Repository<AssetRentStatus>().Delete(dbAssetRentStatus);
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
