using MediatR;
using Onion.Application.Mediator.Results.AppUserProfileResults.QueryResults;

namespace Onion.Application.Mediator.Commands.AppUserProfileCommands
{
    public class RemoveAppUserProfileCommand : IRequest<GetAppUserProfileByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveAppUserProfileCommand(int id)
        {
            Id = id;
        }
    }
}
