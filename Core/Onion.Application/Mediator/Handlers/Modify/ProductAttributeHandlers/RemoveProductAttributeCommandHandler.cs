using MediatR;
using Onion.Application.Mediator.Commands.ProductAttributeCommands;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Modify.ProductAttributeHandlers
{
    public class RemoveProductAttributeCommandHandler : IRequestHandler<RemoveProductAttributeCommand>
    {
        private readonly IProductAttributeRepository _repository;

        public RemoveProductAttributeCommandHandler(IProductAttributeRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveProductAttributeCommand request, CancellationToken cancellationToken)
        {
            ProductAttribute value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
