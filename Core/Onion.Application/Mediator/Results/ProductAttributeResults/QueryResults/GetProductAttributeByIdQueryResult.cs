namespace Onion.Application.Mediator.Results.ProductAttributeResults.QueryResults
{
    public class GetProductAttributeByIdQueryResult
    {
        public int Id { get; set; }
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public string? Description { get; set; }
        public bool IsRequired { get; set; }
        public string? ValidationRule { get; set; }
    }
}
