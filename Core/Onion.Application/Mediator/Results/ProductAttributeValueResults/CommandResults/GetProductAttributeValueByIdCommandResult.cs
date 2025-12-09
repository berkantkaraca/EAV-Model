namespace Onion.Application.Mediator.Results.ProductAttributeValueResults.CommandResults
{
    public class GetProductAttributeValueByIdCommandResult
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public string AttributeValue { get; set; }
        public string? AttributeName { get; set; }
        public string? ProductName { get; set; }
    }
}
