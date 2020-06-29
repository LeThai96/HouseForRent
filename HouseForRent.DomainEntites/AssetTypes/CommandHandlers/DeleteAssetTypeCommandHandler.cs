using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AssetTypes.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.AssetTypes.CommandHandlers
{
    public class DeleteAssetTypeCommandHandler : IRequestHandler<DeleteAssetTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteAssetTypeCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(DeleteAssetTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbAssetType = await _unitOfWork.Repository<AssetType>().FindByPK(request.Id);
                if (dbAssetType != null)
                {
                    _unitOfWork.Repository<AssetType>().Delete(dbAssetType);
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
