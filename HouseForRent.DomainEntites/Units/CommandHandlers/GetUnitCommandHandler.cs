using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.Units.Commands;
using HouseForRent.DomainEntities.Units.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.Units.CommandHandlers
{
    public class GetUnitCommandHandler : IRequestHandler<GetUnitCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUnitCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetUnitCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbUnit = await _unitOfWork.Repository<Data.Entities.Unit>().FindByCondition(x => x.UnitName == request.UnitName);

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = _mapper.Map<UnitDTO>(dbUnit)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
