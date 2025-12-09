using MediatR;
using Onion.Application.Mediator.Results.OrderDetailResults.QueryResults;

namespace Onion.Application.Mediator.Commands.OrderDetailCommands
{
    public class UpdateOrderDetailCommand : IRequest<GetOrderDetailByIdQueryResult>
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
