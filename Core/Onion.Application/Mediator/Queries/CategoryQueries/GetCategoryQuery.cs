using MediatR;
using Onion.Application.Mediator.Results.CategoryResults.QueryResults;

namespace Onion.Application.Mediator.Queries.CategoryQueries
{
    public class GetCategoryQuery : IRequest<List<GetCategoryQueryResult>>
    {

    }
}
