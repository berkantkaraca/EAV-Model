using AutoMapper;
using MediatR;
using Onion.Application.Mediator.Commands.ProductAttributeValueCommands;
using Onion.Application.Mediator.Results.ProductAttributeValueResults.QueryResults;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Modify.ProductAttributeValueHandlers
{
    public class CreateProductAttributeValueCommandHandler : IRequestHandler<CreateProductAttributeValueCommand, GetProductAttributeValueByIdQueryResult>
    {
        private readonly IProductAttributeValueRepository _repository;
        private readonly IMapper _mapper;

        public CreateProductAttributeValueCommandHandler(IProductAttributeValueRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductAttributeValueByIdQueryResult> Handle(CreateProductAttributeValueCommand request, CancellationToken cancellationToken)
        {
            ProductAttributeValue productAttributeValue = _mapper.Map<ProductAttributeValue>(request);
            await _repository.CreateAsync(productAttributeValue);

            return _mapper.Map<GetProductAttributeValueByIdQueryResult>(productAttributeValue);
        }
    }
}
