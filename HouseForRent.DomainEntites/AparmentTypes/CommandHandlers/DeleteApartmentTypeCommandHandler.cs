using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AparmentTypes.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.AparmentTypes.CommandHandlers
{
    public class DeleteApartmentTypeCommandHandler : IRequestHandler<DeleteApartmentTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteApartmentTypeCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(DeleteApartmentTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbApartmentType = await _unitOfWork.Repository<ApartmentType>().FindByPK(request.Id);
                if (dbApartmentType != null)
                {
                    _unitOfWork.Repository<ApartmentType>().Delete(dbApartmentType);
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
