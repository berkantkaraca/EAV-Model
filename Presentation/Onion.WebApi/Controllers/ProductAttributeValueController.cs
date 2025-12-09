using MediatR;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.Mediator.Commands.ProductAttributeValueCommands;
using Onion.Application.Mediator.Queries.ProductAttributeValueQueries;
using Onion.Application.Mediator.Results.ProductAttributeValueResults.QueryResults;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAttributeValueController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductAttributeValueController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProductAttributeValueList()
        {
            List<GetProductAttributeValueQueryResult> values = await _mediator.Send(new GetProductAttributeValueQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAttributeValue(int id)
        {
            GetProductAttributeValueByIdQueryResult value = await _mediator.Send(new GetProductAttributeValueByIdQuery(id));
            return Ok(value);
        }

        [HttpGet("product/{productId}")]
        public async Task<IActionResult> GetProductAttributeValuesByProductId(int productId)
        {
            List<GetProductAttributeValueQueryResult> values = await _mediator.Send(new GetProductAttributeValuesByProductIdQuery(productId));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAttributeValue(CreateProductAttributeValueCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductAttributeValue(UpdateProductAttributeValueCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün öznitelik değeri başarıyla güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAttributeValue(int id)
        {
            await _mediator.Send(new RemoveProductAttributeValueCommand(id));
            return Ok("Ürün öznitelik değeri başarıyla silindi");
        }
    }
}
