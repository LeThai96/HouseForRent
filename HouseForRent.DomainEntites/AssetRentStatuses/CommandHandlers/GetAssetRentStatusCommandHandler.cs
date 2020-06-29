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
    public class GetAssetRentStatusCommandHandler : IRequestHandler<GetAssetRentStatusCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAssetRentStatusCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetAssetRentStatusCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbAssetRentStatus = await _unitOfWork.Repository<AssetRentStatus>().FindByCondition(x => x.Type == request.Type);

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = _mapper.Map<AssetRentStatusDTO>(dbAssetRentStatus)
                }); ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
