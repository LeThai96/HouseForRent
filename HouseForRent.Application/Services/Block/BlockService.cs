using AutoMapper;
using HouseForRent.Application.Models.Block;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.Blocks.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HouseForRent.Application.Services.Block
{
    public class BlockService : IBlockService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public BlockService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<Response> CreateBlock(CreateBlockViewModel model)
        {
            var createBlockCommand = _mapper.Map<CreateBlockCommand>(model);
            return await _mediator.Send(createBlockCommand);
        }

        public async Task<Response> DeleteBlock(DeleteBlockViewModel model)
        {
            var deleteBlockCommand = _mapper.Map<DeleteBlockCommand>(model);
            return await _mediator.Send(deleteBlockCommand);
        }

        public async Task<Response> GetAllBlocks(GetAllBlocksViewModel model)
        {
            var getAllBlocksCommand = _mapper.Map<GetAllBlocksCommand>(model);
            return await _mediator.Send(getAllBlocksCommand);
        }

        public async Task<Response> GetBlock(GetBlockViewModel model)
        {
            var getBlockCommand = _mapper.Map<GetBlockCommand>(model);
            return await _mediator.Send(getBlockCommand);
        }

        public async Task<Response> UpdateBlock(UpdateBlockViewModel model)
        {
            var updateBlockCommand = _mapper.Map<UpdateBlockCommand>(model);
            return await _mediator.Send(updateBlockCommand);
        }
    }
}
