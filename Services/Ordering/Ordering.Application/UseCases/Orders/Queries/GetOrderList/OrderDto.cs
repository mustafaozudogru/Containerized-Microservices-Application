namespace Ordering.Application.UseCases.Orders.Queries.GetOrderList
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
    }
}
