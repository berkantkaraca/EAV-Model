using MediatR;
using Onion.Application.Mediator.Results.ProductResults.QueryResults;

namespace Onion.Application.Mediator.Commands.ProductCommands
{
    public class RemoveProductCommand : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveProductCommand(int id)
        {
            Id = id;
        }
    }
}
