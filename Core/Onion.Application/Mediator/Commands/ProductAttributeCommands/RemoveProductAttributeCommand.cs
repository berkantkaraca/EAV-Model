using MediatR;

namespace Onion.Application.Mediator.Commands.ProductAttributeCommands
{
    public class RemoveProductAttributeCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductAttributeCommand(int id)
        {
            Id = id;
        }
    }
}
