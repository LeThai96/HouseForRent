using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AssetRentStatuses.Commands;
using HouseForRent.DomainEntities.AssetRentStatuses.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.AssetRentStatuses.CommandHandlers
{
    public class UpdateAssetRentStatusCommandHandler : IRequestHandler<UpdateAssetRentStatusCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateAssetRentStatusCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateAssetRentStatusCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbAssetRentStatus = await _unitOfWork.Repository<AssetRentStatus>().FindOne(x => x.Id == request.Id);
                if (dbAssetRentStatus != null)
                {
                    dbAssetRentStatus.Status = request.Status;
                    dbAssetRentStatus.Description = request.Description;
                    _unitOfWork.Repository<AssetRentStatus>().Update(dbAssetRentStatus);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<AssetRentStatusDTO>(dbAssetRentStatus)
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
