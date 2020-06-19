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
    public class CreateUnitCommandHandler : IRequestHandler<CreateUnitCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateUnitCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(CreateUnitCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbUnit = await _unitOfWork.Repository<Data.Entities.Unit>().FindOne(x => x.UnitName == request.UnitName);

                if (dbUnit == null)
                {
                    var unit = new Data.Entities.Unit()
                    {
                        UnitName = request.UnitName,
                        Description = request.Description
                    };
                    _unitOfWork.Repository<Data.Entities.Unit>().Insert(unit);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<UnitDTO>(unit)
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
