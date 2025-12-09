using AutoMapper;
using MediatR;
using Onion.Application.Mediator.Queries.ProductAttributeQueries;
using Onion.Application.Mediator.Results.ProductAttributeResults.QueryResults;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Read.ProductAttributeHandlers
{
    public class GetProductAttributeQueryHandler : IRequestHandler<GetProductAttributeQuery, List<GetProductAttributeQueryResult>>
    {
        private readonly IProductAttributeRepository _repository;
        private readonly IMapper _mapper;

        public GetProductAttributeQueryHandler(IProductAttributeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetProductAttributeQueryResult>> Handle(GetProductAttributeQuery request, CancellationToken cancellationToken)
        {
            List<ProductAttribute> values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetProductAttributeQueryResult>>(values);
        }
    }
}
