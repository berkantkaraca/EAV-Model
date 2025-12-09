using MediatR;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;

namespace Onion.Application.Mediator.Queries.AppUserQueries
{
    //IRequest isteğin ne türden döneceğini bildirir
    public class GetAppUserQuery : IRequest<List<GetAppUserQueryResult>>   
    {

    }
}
