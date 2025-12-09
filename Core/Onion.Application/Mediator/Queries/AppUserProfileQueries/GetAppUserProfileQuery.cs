using MediatR;
using Onion.Application.Mediator.Results.AppUserProfileResults.QueryResults;

namespace Onion.Application.Mediator.Queries.AppUserProfileQueries
{
    public class GetAppUserProfileQuery : IRequest<List<GetAppUserProfileQueryResult>>
    {

    }
}
