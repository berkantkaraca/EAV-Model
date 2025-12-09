using MediatR;
using Onion.Application.Mediator.Results.OrderResults.QueryResults;

namespace Onion.Application.Mediator.Commands.OrderCommands
{
    public class RemoveOrderCommand : IRequest<GetOrderByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveOrderCommand(int id)
        {
            Id = id;
        }
    }
}
