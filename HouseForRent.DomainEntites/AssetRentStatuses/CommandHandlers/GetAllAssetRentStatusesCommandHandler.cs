using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AparmentTypes.Commands;
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
    public class GetAllAssetRentStatusesCommandHandler : IRequestHandler<GetAllAssetRentStatusesCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllAssetRentStatusesCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetAllAssetRentStatusesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbApartmentTypes = await _unitOfWork.Repository<AssetRentStatus>().FindAll();

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = _mapper.Map<AssetRentStatusDTO>(dbApartmentTypes)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
