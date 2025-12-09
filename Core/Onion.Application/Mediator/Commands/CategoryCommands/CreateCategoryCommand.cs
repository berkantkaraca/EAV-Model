using MediatR;
using Onion.Application.Mediator.Results.CategoryResults.QueryResults;

namespace Onion.Application.Mediator.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest<GetCategoryByIdQueryResult>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
