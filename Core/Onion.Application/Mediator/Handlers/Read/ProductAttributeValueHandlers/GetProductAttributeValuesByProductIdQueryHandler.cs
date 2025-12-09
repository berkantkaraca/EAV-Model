using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Onion.Application.Mediator.Queries.ProductAttributeValueQueries;
using Onion.Application.Mediator.Results.ProductAttributeValueResults.QueryResults;
using Onion.Contract.RepositoryInterfaces;

namespace Onion.Application.Mediator.Handlers.Read.ProductAttributeValueHandlers
{
    public class GetProductAttributeValuesByProductIdQueryHandler : IRequestHandler<GetProductAttributeValuesByProductIdQuery, List<GetProductAttributeValueQueryResult>>
    {
        private readonly IProductAttributeValueRepository _repository;
        private readonly IMapper _mapper;

        public GetProductAttributeValuesByProductIdQueryHandler(IProductAttributeValueRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetProductAttributeValueQueryResult>> Handle(GetProductAttributeValuesByProductIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.Where(x => x.ProductId == request.ProductId).ToListAsync();
            return _mapper.Map<List<GetProductAttributeValueQueryResult>>(values);
        }
    }
}
