using MediatR;
using Onion.Application.Mediator.Results.ProductAttributeValueResults.QueryResults;

namespace Onion.Application.Mediator.Queries.ProductAttributeValueQueries
{
    public class GetProductAttributeValueQuery : IRequest<List<GetProductAttributeValueQueryResult>>
    {
    }
}
