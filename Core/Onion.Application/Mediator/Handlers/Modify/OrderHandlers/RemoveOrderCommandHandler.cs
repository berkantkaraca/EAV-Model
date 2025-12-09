using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.OrderCommands;
using Onion.Application.Mediator.Results.OrderResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Modify.OrderHandlers
{
    public class RemoveOrderCommandHandler : IRequestHandler<RemoveOrderCommand, GetOrderByIdQueryResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public RemoveOrderCommandHandler(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderByIdQueryResult> Handle(RemoveOrderCommand request, CancellationToken cancellationToken)
        {
            Order value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
            return _mapper.Map<GetOrderByIdQueryResult>(value);
        }
    }
}
