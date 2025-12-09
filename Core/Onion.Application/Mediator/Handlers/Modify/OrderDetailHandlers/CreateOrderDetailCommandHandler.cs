using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.OrderDetailCommands;
using Onion.Application.Mediator.Results.OrderDetailResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Modify.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommand, GetOrderDetailByIdQueryResult>
    {
        private readonly IOrderDetailRepository _repository;
        private readonly IMapper _mapper;

        public CreateOrderDetailCommandHandler(IOrderDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            OrderDetail orderDetail = _mapper.Map<OrderDetail>(request);
            await _repository.CreateAsync(orderDetail);
            return _mapper.Map<GetOrderDetailByIdQueryResult>(orderDetail);
        }
    }
}
