using MediatR;
using Onion.Application.Mediator.Results.CategoryResults.QueryResults;

namespace Onion.Application.Mediator.Commands.CategoryCommands
{
    public class RemoveCategoryCommand : IRequest<GetCategoryByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
