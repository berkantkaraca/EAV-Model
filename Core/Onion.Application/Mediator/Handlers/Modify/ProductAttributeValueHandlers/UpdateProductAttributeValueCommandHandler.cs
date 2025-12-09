using AutoMapper;
using MediatR;
using Onion.Application.Mediator.Commands.ProductAttributeValueCommands;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Modify.ProductAttributeValueHandlers
{
    public class UpdateProductAttributeValueCommandHandler : IRequestHandler<UpdateProductAttributeValueCommand>
    {
        private readonly IProductAttributeValueRepository _repository;
        private readonly IMapper _mapper;

        public UpdateProductAttributeValueCommandHandler(IProductAttributeValueRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateProductAttributeValueCommand request, CancellationToken cancellationToken)
        {
            ProductAttributeValue oldValue = await _repository.GetByIdAsync(request.Id);
            ProductAttributeValue newValue = _mapper.Map<ProductAttributeValue>(request);
            await _repository.UpdateAsync(oldValue, newValue);
        }
    }
}
