namespace Onion.Application.Mediator.Results.OrderDetailResults.CommandResults
{
    public class GetOrderDetailByIdCommandResult
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
