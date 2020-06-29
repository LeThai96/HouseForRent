using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AparmentTypes.Commands;
using HouseForRent.DomainEntities.AssetTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.AssetTypes.CommandHandlers
{
    public class GetAllAssetTypesCommandHandler : IRequestHandler<GetAllApartmentTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllAssetTypesCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetAllApartmentTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbAssetTypes = await _unitOfWork.Repository<AssetType>().FindAll();

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = _mapper.Map<AssetTypeDTO>(dbAssetTypes)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
