using MediatR;
using Onion.Application.Mediator.Results.ProductAttributeResults.QueryResults;

namespace Onion.Application.Mediator.Commands.ProductAttributeCommands
{
    public class CreateProductAttributeCommand : IRequest<GetProductAttributeByIdQueryResult>
    {
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public string? Description { get; set; }
        public bool IsRequired { get; set; }
        public string? ValidationRule { get; set; }
    }
}
