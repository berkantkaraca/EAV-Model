using MediatR;
using Onion.Application.Mediator.Results.OrderResults.QueryResults;

namespace Onion.Application.Mediator.Commands.OrderCommands
{
    public class CreateOrderCommand : IRequest<GetOrderByIdQueryResult>
    {
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}
