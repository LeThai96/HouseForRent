using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.MotorTypes.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.MotorTypes.CommandHandlers
{
    public class DeleteMotorTypeCommandHandler : IRequestHandler<DeleteMotorTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteMotorTypeCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(DeleteMotorTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbMotorType = await _unitOfWork.Repository<MotorType>().FindByPK(request.Id);
                if (dbMotorType != null)
                {
                    _unitOfWork.Repository<MotorType>().Delete(dbMotorType);
                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
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
