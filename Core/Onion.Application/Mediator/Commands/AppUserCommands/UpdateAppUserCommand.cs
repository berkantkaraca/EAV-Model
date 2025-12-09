using MediatR;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;

namespace Onion.Application.Mediator.Commands.AppUserCommands
{
    public class UpdateAppUserCommand : IRequest<GetAppUserByIdQueryResult>
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
