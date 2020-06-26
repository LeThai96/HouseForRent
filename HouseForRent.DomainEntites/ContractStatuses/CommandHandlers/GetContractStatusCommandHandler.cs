using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.ContractStatuses.Commands;
using HouseForRent.DomainEntities.ContractStatuses.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.ContractStatuses.CommandHandlers
{
    public class GetContractStatusCommandHandler : IRequestHandler<CreateContractStatusCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetContractStatusCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(CreateContractStatusCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbContractStatus = await _unitOfWork.Repository<ContractStatus>().FindOne(x => x.Status == request.Status);

                if (dbContractStatus == null)
                {
                    var assetRentStatus = new ContractStatus()
                    {
                        Status = request.Status,
                        Description = request.Description
                    };
                    _unitOfWork.Repository<ContractStatus>().Insert(dbContractStatus);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<ContractStatusDTO>(dbContractStatus)
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
