namespace Onion.Application.Mediator.Results.ProductResults.CommandResults
{
    public class GetProductByIdCommandResult
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }
    }
}
