using AutoMapper;
using MediatR;
using Onion.Application.Mediator.Queries.ProductAttributeValueQueries;
using Onion.Application.Mediator.Results.ProductAttributeValueResults.QueryResults;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Read.ProductAttributeValueHandlers
{
    public class GetProductAttributeValueQueryHandler : IRequestHandler<GetProductAttributeValueQuery, List<GetProductAttributeValueQueryResult>>
    {
        private readonly IProductAttributeValueRepository _repository;
        private readonly IMapper _mapper;

        public GetProductAttributeValueQueryHandler(IProductAttributeValueRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetProductAttributeValueQueryResult>> Handle(GetProductAttributeValueQuery request, CancellationToken cancellationToken)
        {
            List<ProductAttributeValue> values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetProductAttributeValueQueryResult>>(values);
        }
    }
}
