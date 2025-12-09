using Onion.Application.Mediator.Commands.OrderDetailCommands;
using Onion.Application.Mediator.Queries.OrderDetailQueries;
using Onion.Application.Mediator.Results.OrderDetailResults.QueryResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> OrderDetailList()
        {
            List<GetOrderDetailQueryResult> values = await _mediator.Send(new GetOrderDetailQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderDetail(int id)
        {
            GetOrderDetailByIdQueryResult value = await _mediator.Send(new GetOrderDetailByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail(CreateOrderDetailCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail(UpdateOrderDetailCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetail(int id)
        {
            var result = await _mediator.Send(new RemoveOrderDetailCommand(id));
            return Ok(result);
        }
    }
}
