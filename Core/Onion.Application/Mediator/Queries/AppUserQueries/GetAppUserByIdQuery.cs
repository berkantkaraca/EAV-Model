using MediatR;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;

namespace Onion.Application.Mediator.Queries.AppUserQueries
{
    public class GetAppUserByIdQuery : IRequest<GetAppUserByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAppUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
