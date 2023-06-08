namespace Ordering.Application.UseCases.Orders.Commands.CreateOrder
{
    public class ShoppingCartItemDto
    {
        public ShoppingCartItemDto(int quantity, string color, decimal price, string productName)
        {
            Quantity = quantity;
            Color = color;
            Price = price;
            ProductName = productName;
        }

        public int Quantity { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public string ProductName { get; set; }
    }
}
