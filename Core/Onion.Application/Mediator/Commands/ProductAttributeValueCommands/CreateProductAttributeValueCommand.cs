using MediatR;
using Onion.Application.Mediator.Results.ProductAttributeValueResults.QueryResults;

namespace Onion.Application.Mediator.Commands.ProductAttributeValueCommands
{
    public class CreateProductAttributeValueCommand : IRequest<GetProductAttributeValueByIdQueryResult>
    {
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public string AttributeValue { get; set; }
    }
}
