using MediatR;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.Mediator.Commands.ProductAttributeCommands;
using Onion.Application.Mediator.Queries.ProductAttributeQueries;
using Onion.Application.Mediator.Results.ProductAttributeResults.QueryResults;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAttributeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductAttributeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProductAttributeList()
        {
            List<GetProductAttributeQueryResult> values = await _mediator.Send(new GetProductAttributeQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAttribute(int id)
        {
            GetProductAttributeByIdQueryResult value = await _mediator.Send(new GetProductAttributeByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAttribute(CreateProductAttributeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductAttribute(UpdateProductAttributeCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün özniteliği başarıyla güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAttribute(int id)
        {
            await _mediator.Send(new RemoveProductAttributeCommand(id));
            return Ok("Ürün özniteliği başarıyla silindi");
        }
    }
}
