using AutoMapper;
using MediatR;
using Onion.Application.Mediator.Commands.ProductAttributeCommands;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Modify.ProductAttributeHandlers
{
    public class UpdateProductAttributeCommandHandler : IRequestHandler<UpdateProductAttributeCommand>
    {
        private readonly IProductAttributeRepository _repository;
        private readonly IMapper _mapper;

        public UpdateProductAttributeCommandHandler(IProductAttributeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateProductAttributeCommand request, CancellationToken cancellationToken)
        {
            ProductAttribute oldValue = await _repository.GetByIdAsync(request.Id);
            ProductAttribute newValue = _mapper.Map<ProductAttribute>(request);
            await _repository.UpdateAsync(oldValue, newValue);
        }
    }
}
