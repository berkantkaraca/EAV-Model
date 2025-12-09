using MediatR;
using Onion.Application.Mediator.Commands.ProductAttributeValueCommands;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Modify.ProductAttributeValueHandlers
{
    public class RemoveProductAttributeValueCommandHandler : IRequestHandler<RemoveProductAttributeValueCommand>
    {
        private readonly IProductAttributeValueRepository _repository;

        public RemoveProductAttributeValueCommandHandler(IProductAttributeValueRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveProductAttributeValueCommand request, CancellationToken cancellationToken)
        {
            ProductAttributeValue value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
