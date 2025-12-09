using MediatR;
using Onion.Application.Mediator.Results.AppUserProfileResults.QueryResults;

namespace Onion.Application.Mediator.Queries.AppUserProfileQueries
{
    public class GetAppUserProfileByIdQuery : IRequest<GetAppUserProfileByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAppUserProfileByIdQuery(int id)
        {
            Id = id;
        }
    }
}
