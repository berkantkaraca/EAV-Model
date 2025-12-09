using MediatR;
using Onion.Application.Mediator.Results.CategoryResults.QueryResults;

namespace Onion.Application.Mediator.Commands.CategoryCommands
{
    public class UpdateCategoryCommand : IRequest<GetCategoryByIdQueryResult>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
