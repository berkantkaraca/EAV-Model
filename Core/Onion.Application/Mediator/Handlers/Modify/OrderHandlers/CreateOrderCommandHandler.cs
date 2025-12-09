using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.OrderCommands;
using Onion.Application.Mediator.Results.OrderResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Modify.OrderHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, GetOrderByIdQueryResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderByIdQueryResult> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Order order = _mapper.Map<Order>(request);

            await _repository.CreateAsync(order);
            return _mapper.Map<GetOrderByIdQueryResult>(order);
        }
    }
}
