using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseForRent.Application.Models.ApartmentType;
using HouseForRent.Application.Services.ApartmentType;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.AparmentTypes.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseForRent.BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentTypeController : ControllerBase
    {
        private readonly IApartmentTypeService _apartmentTypeService;

        public ApartmentTypeController(IApartmentTypeService apartmentTypeService)
        {
            _apartmentTypeService = apartmentTypeService;
        }

        [HttpGet]
        public async Task<Response> Get([FromQuery]GetApartmentTypeViewModel model)
        {
            return await _apartmentTypeService.GetApartmentType(model);
        }

        [HttpGet("all")]
        public async Task<Response> GetAll([FromQuery] GetAllApartmentTypesViewModel model)
        {
            return await _apartmentTypeService.GetAllApartmentType(model);
        }

        [HttpPost]
        public async Task<Response> CreateApartmentType([FromForm]CreateApartmentTypeViewModel model)
        {
            return await _apartmentTypeService.CreateApartmentType(model);
        }

        [HttpPut]
        public async Task<Response> UpdateApartmentType([FromForm] UpdateApartmentTypeViewModel model)
        {
            return await _apartmentTypeService.UpdateApartmentType(model);
        }

        [HttpDelete]
        public async Task<Response> DeleteApartmentType([FromForm] DeleteApartmentTypeViewModel model)
        {
            return await _apartmentTypeService.DeleteApartmentType(model);
        }
    }
}
