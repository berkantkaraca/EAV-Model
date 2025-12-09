using MediatR;
using Onion.Application.Mediator.Results.OrderDetailResults.QueryResults;

namespace Onion.Application.Mediator.Commands.OrderDetailCommands
{
    public class CreateOrderDetailCommand : IRequest<GetOrderDetailByIdQueryResult>
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
