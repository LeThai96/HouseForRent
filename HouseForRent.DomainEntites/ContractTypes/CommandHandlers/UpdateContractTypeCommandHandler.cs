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
    public class UpdateContractTypeCommandHandler : IRequestHandler<UpdateContractTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateContractTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateContractTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbApartmentType = await _unitOfWork.Repository<ContractType>().FindOne(x => x.Id == request.Id);
                if (dbApartmentType != null)
                {
                    dbApartmentType.Type = request.Type;
                    dbApartmentType.Description = request.Description;
                    _unitOfWork.Repository<ContractType>().Update(dbApartmentType);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<ContractTypeDTO>(dbApartmentType)
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
