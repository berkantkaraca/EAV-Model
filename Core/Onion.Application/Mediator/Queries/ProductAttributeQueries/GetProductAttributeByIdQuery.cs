using MediatR;
using Onion.Application.Mediator.Results.ProductAttributeResults.QueryResults;

namespace Onion.Application.Mediator.Queries.ProductAttributeQueries
{
    public class GetProductAttributeByIdQuery : IRequest<GetProductAttributeByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductAttributeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
