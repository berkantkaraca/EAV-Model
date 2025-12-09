using MediatR;

namespace Onion.Application.Mediator.Commands.ProductAttributeValueCommands
{
    public class RemoveProductAttributeValueCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductAttributeValueCommand(int id)
        {
            Id = id;
        }
    }
}
