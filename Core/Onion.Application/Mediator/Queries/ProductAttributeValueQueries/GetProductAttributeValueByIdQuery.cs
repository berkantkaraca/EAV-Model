using MediatR;
using Onion.Application.Mediator.Results.ProductAttributeValueResults.QueryResults;

namespace Onion.Application.Mediator.Queries.ProductAttributeValueQueries
{
    public class GetProductAttributeValueByIdQuery : IRequest<GetProductAttributeValueByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductAttributeValueByIdQuery(int id)
        {
            Id = id;
        }
    }
}
