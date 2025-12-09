using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Queries.ProductQueries;
using Onion.Application.Mediator.Results.ProductResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Read.ProductHandlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            List<Product> values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetProductQueryResult>>(values);
        }
    }
}
