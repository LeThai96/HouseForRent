using DomainCore.UnitOfWork;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.Common;
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
    public class GetApartmentTypeCommandHandle : IRequestHandler<GetApartmentTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetApartmentTypeCommandHandle(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(GetApartmentTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbApartmentType = await _unitOfWork.Repository<ApartmentType>().FindByCondition(x => x.Type == request.Type);

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = dbApartmentType
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
