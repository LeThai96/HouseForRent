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
    public class CreateAssetRentStatusCommandHandler : IRequestHandler<CreateAssetRentStatusCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateAssetRentStatusCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(CreateAssetRentStatusCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbAssetRentStatus = await _unitOfWork.Repository<AssetRentStatus>().FindOne(x => x.Status == request.Status);

                if (dbAssetRentStatus == null)
                {
                    var assetRentStatus = new AssetRentStatus()
                    {
                        Status = request.Status,
                        Description = request.Description
                    };
                    _unitOfWork.Repository<AssetRentStatus>().Insert(dbAssetRentStatus);

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
