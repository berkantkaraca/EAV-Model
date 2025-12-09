using MediatR;
using Onion.Application.Mediator.Results.OrderResults.QueryResults;

namespace Onion.Application.Mediator.Queries.OrderQueries
{
    public class GetOrderQuery : IRequest<List<GetOrderQueryResult>>
    {

    }
}
