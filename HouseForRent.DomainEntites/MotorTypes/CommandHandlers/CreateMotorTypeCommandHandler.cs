using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.MotorTypes.Commands;
using HouseForRent.DomainEntities.MotorTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.MotorTypes.CommandHandlers
{
    public class CreateMotorTypeCommandHandler : IRequestHandler<CreateMotorTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateMotorTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(CreateMotorTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbMotorType = await _unitOfWork.Repository<MotorType>().FindOne(x => x.Type == request.Type);

                if (dbMotorType == null)
                {
                    var motorType = new MotorType()
                    {
                        Type = request.Type,
                        Description = request.Description
                    };
                    _unitOfWork.Repository<MotorType>().Insert(dbMotorType);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<MotorTypeDTO>(motorType)
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
