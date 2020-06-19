using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.MotorTypes.Commands;
using HouseForRent.DomainEntities.MotorTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.MotorTypes.CommandHandlers
{
    public class GetAllMotorTypesCommandHandler : IRequestHandler<GetAllMotorTypesCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllMotorTypesCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(GetAllMotorTypesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbMotorTypes = await _unitOfWork.Repository<MotorType>().FindAll();

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = dbMotorTypes.Select(x => new MotorTypeDTO()
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
