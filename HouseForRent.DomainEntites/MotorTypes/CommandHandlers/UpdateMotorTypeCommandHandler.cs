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
    public class UpdateMotorTypeCommandHandler : IRequestHandler<UpdateMotorTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateMotorTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateMotorTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbMotorType = await _unitOfWork.Repository<MotorType>().FindOne(x => x.Id == request.Id);
                if (dbMotorType != null)
                {
                    dbMotorType.Type = request.Type;
                    dbMotorType.Description = request.Description;
                    _unitOfWork.Repository<MotorType>().Update(dbMotorType);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<MotorTypeDTO>(dbMotorType)
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
