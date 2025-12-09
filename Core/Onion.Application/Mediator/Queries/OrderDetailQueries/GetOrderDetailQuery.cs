using MediatR;
using Onion.Application.Mediator.Results.OrderDetailResults.QueryResults;

namespace Onion.Application.Mediator.Queries.OrderDetailQueries
{
    public class GetOrderDetailQuery : IRequest<List<GetOrderDetailQueryResult>>
    {

    }
}
