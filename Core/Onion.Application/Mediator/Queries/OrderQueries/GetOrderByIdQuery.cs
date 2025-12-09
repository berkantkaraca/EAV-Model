using MediatR;
using Onion.Application.Mediator.Results.OrderResults.QueryResults;

namespace Onion.Application.Mediator.Queries.OrderQueries
{
    public class GetOrderByIdQuery : IRequest<GetOrderByIdQueryResult>
    {
        public int Id { get; set; }

        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
