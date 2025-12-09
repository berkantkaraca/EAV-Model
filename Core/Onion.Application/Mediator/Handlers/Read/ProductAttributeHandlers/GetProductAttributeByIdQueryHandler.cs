using AutoMapper;
using MediatR;
using Onion.Application.Mediator.Queries.ProductAttributeQueries;
using Onion.Application.Mediator.Results.ProductAttributeResults.QueryResults;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Mediator.Handlers.Read.ProductAttributeHandlers
{
    public class GetProductAttributeByIdQueryHandler : IRequestHandler<GetProductAttributeByIdQuery, GetProductAttributeByIdQueryResult>
    {
        private readonly IProductAttributeRepository _repository;
        private readonly IMapper _mapper;

        public GetProductAttributeByIdQueryHandler(IProductAttributeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductAttributeByIdQueryResult> Handle(GetProductAttributeByIdQuery request, CancellationToken cancellationToken)
        {
            ProductAttribute value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetProductAttributeByIdQueryResult>(value);
        }
    }
}
