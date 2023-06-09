namespace Ordering.Application.UseCases.Orders.Queries.OrderQueryDto
{
    public class OrderItemDto
    {
        public int Quantity { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public string ProductName { get; set; }
    }
}
