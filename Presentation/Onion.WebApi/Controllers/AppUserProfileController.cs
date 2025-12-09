using Onion.Application.Mediator.Commands.AppUserProfileCommands;
using Onion.Application.Mediator.Queries.AppUserProfileQueries;
using Onion.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserProfileController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppUserProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AppUserProfileList()
        {
            List<GetAppUserProfileQueryResult> values = await _mediator.Send(new GetAppUserProfileQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppUserProfile(int id)
        {
            GetAppUserProfileByIdQueryResult value = await _mediator.Send(new GetAppUserProfileByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppUserProfile(CreateAppUserProfileCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAppUserProfile(UpdateAppUserProfileCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUserProfile(int id)
        {
            var result = await _mediator.Send(new RemoveAppUserProfileCommand(id));
            return Ok(result);
        }
    }
}
