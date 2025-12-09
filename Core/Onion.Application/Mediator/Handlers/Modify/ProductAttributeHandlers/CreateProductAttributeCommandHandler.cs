using AutoMapper;
using MediatR;
using Onion.Application.Mediator.Commands.ProductAttributeCommands;
using Onion.Application.Mediator.Results.ProductAttributeResults.QueryResults;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Modify.ProductAttributeHandlers
{
    public class CreateProductAttributeCommandHandler : IRequestHandler<CreateProductAttributeCommand, GetProductAttributeByIdQueryResult>
    {
        private readonly IProductAttributeRepository _repository;
        private readonly IMapper _mapper;

        public CreateProductAttributeCommandHandler(IProductAttributeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductAttributeByIdQueryResult> Handle(CreateProductAttributeCommand request, CancellationToken cancellationToken)
        {
            ProductAttribute productAttribute = _mapper.Map<ProductAttribute>(request);
            await _repository.CreateAsync(productAttribute);

            return _mapper.Map<GetProductAttributeByIdQueryResult>(productAttribute);
        }
    }
}
