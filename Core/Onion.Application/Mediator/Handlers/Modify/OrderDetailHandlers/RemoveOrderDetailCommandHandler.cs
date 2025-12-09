using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.OrderDetailCommands;
using Onion.Application.Mediator.Results.OrderDetailResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Modify.OrderDetailHandlers
{
    public class RemoveOrderDetailCommandHandler : IRequestHandler<RemoveOrderDetailCommand, GetOrderDetailByIdQueryResult>
    {
        private readonly IOrderDetailRepository _repository;
        private readonly IMapper _mapper;

        public RemoveOrderDetailCommandHandler(IOrderDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(RemoveOrderDetailCommand request, CancellationToken cancellationToken)
        {
            OrderDetail value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
            return _mapper.Map<GetOrderDetailByIdQueryResult>(value);
        }
    }
}
