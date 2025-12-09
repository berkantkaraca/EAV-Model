using MediatR;
using Onion.Application.Mediator.Results.ProductResults.QueryResults;

namespace Onion.Application.Mediator.Commands.ProductCommands
{
    public class CreateProductCommand : IRequest<GetProductByIdQueryResult>
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }
    }
}
