using MediatR;
using Onion.Application.Mediator.Results.ProductResults.QueryResults;

namespace Onion.Application.Mediator.Queries.ProductQueries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {

    }
}
