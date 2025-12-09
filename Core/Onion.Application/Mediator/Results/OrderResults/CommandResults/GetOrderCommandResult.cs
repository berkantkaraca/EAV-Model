namespace Onion.Application.Mediator.Results.OrderResults.CommandResults
{
    public class GetOrderCommandResult
    {
        public int Id { get; set; }
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}
