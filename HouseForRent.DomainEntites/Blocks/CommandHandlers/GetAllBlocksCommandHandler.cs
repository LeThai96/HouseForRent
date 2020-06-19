using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.Blocks.Commands;
using HouseForRent.DomainEntities.Blocks.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.Blocks.CommandHandlers
{
    public class GetAllBlocksCommandHandler : IRequestHandler<GetAllBlocksCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllBlocksCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(GetAllBlocksCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbBlocks = await _unitOfWork.Repository<Block>().FindAll();

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.Success.Key,
                    Message = ErrorCodeMessage.Success.Value,
                    Data = dbBlocks.Select(x => new BlockDTO()
                    {
                        BlockName = x.BlockName,
                        Description = x.Description
                    }).ToList()
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
