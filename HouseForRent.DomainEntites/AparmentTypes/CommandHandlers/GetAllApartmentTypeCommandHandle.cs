using DomainCore.UnitOfWork;
using HouseForRent.Data.Entities;
using HouseForRent.DomainEntities.AparmentTypes.Commands;
using HouseForRent.DomainEntities.AparmentTypes.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.AparmentTypes.CommandHandlers
{
    public class GetAllApartmentTypeCommandHandle : IRequestHandler<GetAllApartmentTypeCommand, List<ApartmentTypeDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllApartmentTypeCommandHandle(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ApartmentTypeDTO>> Handle(GetAllApartmentTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbApartmentTypes = await _unitOfWork.Repository<ApartmentType>().FindAll();

                return dbApartmentTypes.Select(x => new ApartmentTypeDTO()
                {
                    Type = x.Type,
                    Description = x.Description
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
