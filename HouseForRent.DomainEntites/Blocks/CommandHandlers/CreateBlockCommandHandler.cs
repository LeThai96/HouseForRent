using AutoMapper;
using DomainCore.UnitOfWork;
using HouseForRent.Data.Common;
using HouseForRent.Data.Entities;
using HouseForRent.DomainCore.MediatR;
using HouseForRent.DomainEntities.Blocks.Commands;
using HouseForRent.DomainEntities.Blocks.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseForRent.DomainEntities.Blocks.CommandHandlers
{
    public class CreateBlockCommandHandler : IRequestHandler<CreateBlockCommand, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateBlockCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(CreateBlockCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dbBlock = await _unitOfWork.Repository<Block>().FindOne(x => x.BlockName == request.BlockName);

                if (dbBlock == null)
                {
                    var block = new Block()
                    {
                        BlockName = request.BlockName,
                        Description = request.Description
                    };
                    _unitOfWork.Repository<Block>().Insert(block);

                    await _unitOfWork.SaveChangeAsync();

                    return await Task.FromResult(new Response
                    {
                        Code = ErrorCodeMessage.Success.Key,
                        Message = ErrorCodeMessage.Success.Value,
                        Data = _mapper.Map<BlockDTO>(block)
                    }); ;
                }

                return await Task.FromResult(new Response
                {
                    Code = ErrorCodeMessage.IdentityDuplicate.Key,
                    Message = ErrorCodeMessage.IdentityDuplicate.Value,
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
