using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.Blocks.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.Blocks.CommandHandlers
{
    public class DeleteBlockCommandHandler : IRequestHandler<DeleteBlockCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBlockCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(DeleteBlockCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbBlock = await _unitOfWork.Repository<Block>().FindByPK(request.Id);
                if (dbBlock != null)
                {
                    _unitOfWork.Repository<Block>().Delete(dbBlock);
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
