using AutoMapper;
using MediatR;
using Onion.Application.Mediator.Queries.ProductAttributeValueQueries;
using Onion.Application.Mediator.Results.ProductAttributeValueResults.QueryResults;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Read.ProductAttributeValueHandlers
{
    public class GetProductAttributeValueByIdQueryHandler : IRequestHandler<GetProductAttributeValueByIdQuery, GetProductAttributeValueByIdQueryResult>
    {
        private readonly IProductAttributeValueRepository _repository;
        private readonly IMapper _mapper;

        public GetProductAttributeValueByIdQueryHandler(IProductAttributeValueRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductAttributeValueByIdQueryResult> Handle(GetProductAttributeValueByIdQuery request, CancellationToken cancellationToken)
        {
            ProductAttributeValue value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetProductAttributeValueByIdQueryResult>(value);
        }
    }
}
