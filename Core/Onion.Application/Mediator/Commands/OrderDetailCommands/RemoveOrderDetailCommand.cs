using MediatR;
using Onion.Application.Mediator.Results.OrderDetailResults.QueryResults;

namespace Onion.Application.Mediator.Commands.OrderDetailCommands
{
    public class RemoveOrderDetailCommand : IRequest<GetOrderDetailByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveOrderDetailCommand(int id)
        {
            Id = id;
        }
    }
}
