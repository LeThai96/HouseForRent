using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.Units.Commands;
using HouseForRent.DomainEntities.Units.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.Units.CommandHandlers
{
    public class GetAllUnitsCommandHandler : IRequestHandler<GetAllUnitsCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllUnitsCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetAllUnitsCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbUnits = await _unitOfWork.Repository<Data.Entities.Unit>().FindAll();

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = _mapper.Map<UnitDTO>(dbUnits)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
