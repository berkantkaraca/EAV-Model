using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.OrderDetailCommands;
using Onion.Application.Mediator.Results.OrderDetailResults.QueryResults;
using Onion.Domain.Enums;

namespace Onion.Application.Mediator.Handlers.Modify.OrderDetailHandlers
{
    public class UpdateOrderDetailCommandHandler : IRequestHandler<UpdateOrderDetailCommand, GetOrderDetailByIdQueryResult>
    {
        private readonly IOrderDetailRepository _repository;
        private readonly IMapper _mapper;

        public UpdateOrderDetailCommandHandler(IOrderDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(UpdateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            OrderDetail value = await _repository.GetByIdAsync(request.Id);

            value.OrderId = request.OrderId;
            value.ProductId = request.ProductId;
            value.Status = DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;

            await _repository.SaveChangesAsync();
            return _mapper.Map<GetOrderDetailByIdQueryResult>(value);
        }
    }
}
