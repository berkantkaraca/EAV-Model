using MediatR;
using Onion.Application.Mediator.Results.ProductAttributeResults.QueryResults;

namespace Onion.Application.Mediator.Queries.ProductAttributeQueries
{
    public class GetProductAttributeQuery : IRequest<List<GetProductAttributeQueryResult>>
    {
    }
}
