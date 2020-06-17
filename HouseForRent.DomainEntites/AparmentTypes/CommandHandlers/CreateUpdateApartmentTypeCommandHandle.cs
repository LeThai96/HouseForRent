using DomainCore.UnitOfWork;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.Common;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainCore.Repository;
using HouseForRent.DomainEntities.AparmentTypes.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.AparmentTypes.CommandHandlers
{
    public class CreateUpdateApartmentTypeCommandHandle : IRequestHandler<CreateUpdateApartmentTypeCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<ApartmentType> _apartmentTypeRepo;

        public CreateUpdateApartmentTypeCommandHandle(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _apartmentTypeRepo = unitOfWork.Repository<ApartmentType>();
        }

        public async Task<Response> Handle(CreateUpdateApartmentTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var tsk_dbApartmentType = _apartmentTypeRepo.FindByPK(request.Id);
                var dbApartmentType = tsk_dbApartmentType.AsyncState as ApartmentType;
                if (dbApartmentType != null)
                {
                    dbApartmentType.Type = request.Type;
                    dbApartmentType.Description = request.Description;
                    _apartmentTypeRepo.Update(dbApartmentType);
                }
                else
                {
                    var apartmentType = new ApartmentType()
                    {
                        Type = request.Type,
                        Description = request.Description
                    };
                    _apartmentTypeRepo.Insert(apartmentType);
                }

                await _unitOfWork.SaveChangeAsync();

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                });
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            
        }
    }
}
