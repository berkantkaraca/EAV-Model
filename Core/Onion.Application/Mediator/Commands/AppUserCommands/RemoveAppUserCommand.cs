using MediatR;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;

namespace Onion.Application.Mediator.Commands.AppUserCommands
{
    public class RemoveAppUserCommand : IRequest<GetAppUserByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveAppUserCommand(int id)
        {
            Id = id;
        }
    }
}
