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
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.AssetTypes.CommandHandlers
{
    public class UpdateAssetTypeCommandHandler : IRequestHandler<UpdateApartmentTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateAssetTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateApartmentTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbAssetType = await _unitOfWork.Repository<AssetType>().FindOne(x => x.Id == request.Id);
                if (dbAssetType != null)
                {
                    dbAssetType.Type = request.Type;
                    dbAssetType.Description = request.Description;
                    _unitOfWork.Repository<AssetType>().Update(dbAssetType);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<AssetTypeDTO>(dbAssetType)
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
