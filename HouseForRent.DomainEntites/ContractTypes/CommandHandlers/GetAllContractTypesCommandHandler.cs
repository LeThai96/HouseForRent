using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.ContractTypes.Commands;
using HouseForRent.DomainEntities.ContractTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.ContractTypes.CommandHandlers
{
    public class GetAllContractTypesCommandHandler : IRequestHandler<GetAllContractTypesCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllContractTypesCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(GetAllContractTypesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbContractTypes = await _unitOfWork.Repository<ContractType>().FindAll();

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = dbContractTypes.Select(x => new ContractTypeDTO()
                    {
                        Type = x.Type,
                        Description = x.Description
                    }).ToList()
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
