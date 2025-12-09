namespace Onion.Application.Mediator.Results.OrderResults.QueryResults
{
    public class GetOrderQueryResult
    {
        public int Id { get; set; }
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}
