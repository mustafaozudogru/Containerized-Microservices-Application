namespace Cart.Domain.Entities
{
    public class ShoppingCartItem
    {
        public ShoppingCartItem(int quantity, string color, decimal price, string productName)
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
