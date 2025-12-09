using MediatR;
using Onion.Application.Mediator.Results.ProductAttributeValueResults.QueryResults;

namespace Onion.Application.Mediator.Queries.ProductAttributeValueQueries
{
    public class GetProductAttributeValuesByProductIdQuery : IRequest<List<GetProductAttributeValueQueryResult>>
    {
        public int ProductId { get; set; }

        public GetProductAttributeValuesByProductIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
