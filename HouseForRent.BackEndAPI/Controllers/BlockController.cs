using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseForRent.Application.Models.Block;
using HouseForRent.Application.Services.Block;
using HouseForRent.DomainCore.MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseForRent.BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlockController : ControllerBase
    {
        private readonly IBlockService _blockService;

        public BlockController(IBlockService BlockService)
        {
            _blockService = BlockService;
        }

        [HttpGet]
        public async Task<Response> Get([FromQuery] GetBlockViewModel model)
        {
            return await _blockService.GetBlock(model);
        }

        [HttpGet("all")]
        public async Task<Response> GetAll([FromQuery] GetAllBlocksViewModel model)
        {
            return await _blockService.GetAllBlocks(model);
        }

        [HttpPost]
        public async Task<Response> CreateBlock([FromForm] CreateBlockViewModel model)
        {
            return await _blockService.CreateBlock(model);
        }

        [HttpPut]
        public async Task<Response> UpdateBlock([FromForm] UpdateBlockViewModel model)
        {
            return await _blockService.UpdateBlock(model);
        }

        [HttpDelete]
        public async Task<Response> DeleteBlock([FromForm] DeleteBlockViewModel model)
        {
            return await _blockService.DeleteBlock(model);
        }
    }
}
