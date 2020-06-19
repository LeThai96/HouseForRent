using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.ContractTypes.Commands;
using HouseForRent.DomainEntities.ContractTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.ContractTypes.CommandHandlers
{
    public class CreateContractTypeCommandHandler : IRequestHandler<CreateContractTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateContractTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(CreateContractTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbContractType = await _unitOfWork.Repository<ContractType>().FindOne(x => x.Type == request.Type);

                if (dbContractType == null)
                {
                    var contractType = new ContractType()
                    {
                        Type = request.Type,
                        Description = request.Description
                    };
                    _unitOfWork.Repository<ContractType>().Insert(contractType);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<ContractTypeDTO>(contractType)
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
