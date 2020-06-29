using HouseForRent.Application.Models.Block;
using HouseForRent.DomainCore.MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HouseForRent.Application.Services.Block
{
    public interface IBlockService
    {
        Task<Response> CreateBlock(CreateBlockViewModel model);
        Task<Response> UpdateBlock(UpdateBlockViewModel model);
        Task<Response> DeleteBlock(DeleteBlockViewModel model);
        Task<Response> GetAllBlocks(GetAllBlocksViewModel model);
        Task<Response> GetBlock(GetBlockViewModel model);
    }
}
