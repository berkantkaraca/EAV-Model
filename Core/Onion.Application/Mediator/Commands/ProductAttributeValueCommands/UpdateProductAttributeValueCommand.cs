using MediatR;

namespace Onion.Application.Mediator.Commands.ProductAttributeValueCommands
{
    public class UpdateProductAttributeValueCommand : IRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public string AttributeValue { get; set; }
    }
}
