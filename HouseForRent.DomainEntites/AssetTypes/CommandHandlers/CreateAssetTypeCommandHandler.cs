using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AssetTypes.Commands;
using HouseForRent.DomainEntities.AssetTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.AssetTypes.CommandHandlers
{
    public class CreateAssetTypeCommandHandler : IRequestHandler<CreateAssetTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateAssetTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(CreateAssetTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbAssetType = await _unitOfWork.Repository<AssetType>().FindOne(x => x.Type == request.Type);

                if (dbAssetType == null)
                {
                    var assetType = new AssetType()
                    {
                        Type = request.Type,
                        Description = request.Description
                    };
                    _unitOfWork.Repository<AssetType>().Insert(assetType);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<AssetTypeDTO>(assetType)
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
