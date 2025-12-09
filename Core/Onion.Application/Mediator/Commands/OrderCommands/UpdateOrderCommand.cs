using MediatR;
using Onion.Application.Mediator.Results.OrderResults.QueryResults;

namespace Onion.Application.Mediator.Commands.OrderCommands
{
    public class UpdateOrderCommand : IRequest<GetOrderByIdQueryResult>
    {
        public int Id { get; set; }
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}
