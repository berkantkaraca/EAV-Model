using MediatR;
using Onion.Application.Mediator.Results.AppUserProfileResults.QueryResults;

namespace Onion.Application.Mediator.Commands.AppUserProfileCommands
{
    public class CreateAppUserProfileCommand : IRequest<GetAppUserProfileByIdQueryResult>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AppUserId { get; set; }
    }
}
