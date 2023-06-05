namespace Cart.Application.UseCases.Carts.Commands.UpdateShoppingCart
{
    public class UpdateCartItemDto
    {
        public UpdateCartItemDto(int quantity, string color, decimal price, string productName)
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
