using AutoMapper;
using MediatR;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using Onion.Application.Mediator.Commands.OrderCommands;
using Onion.Application.Mediator.Results.OrderResults.QueryResults;
using Onion.Domain.Enums;

namespace Onion.Application.Mediator.Handlers.Modify.OrderHandlers
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, GetOrderByIdQueryResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderByIdQueryResult> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            Order value = await _repository.GetByIdAsync(request.Id);

            value.ShippingAddress = request.ShippingAddress;
            value.AppUserId = request.AppUserId;
            value.Status = DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;

            await _repository.SaveChangesAsync();
            return _mapper.Map<GetOrderByIdQueryResult>(value);
        }
    }
}
