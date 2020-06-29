using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.Units.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.Units.CommandHandlers
{
    public class DeleteUnitCommandHandler : IRequestHandler<DeleteUnitCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteUnitCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(DeleteUnitCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbUnit = await _unitOfWork.Repository<Data.Entities.Unit>().FindByPK(request.Id);
                if (dbUnit != null)
                {
                    _unitOfWork.Repository<Data.Entities.Unit>().Delete(dbUnit);
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
