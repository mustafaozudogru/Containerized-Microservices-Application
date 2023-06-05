namespace Cart.Domain.Entities
{
    public class ShoppingCart
    {
        private readonly List<ShoppingCartItem> _items;

        public ShoppingCart(string userName)
        {
            UserName = userName;
            _items = new List<ShoppingCartItem>();
        }

        public string UserName { get; }

        public IEnumerable<ShoppingCartItem> Items => _items;

        public decimal TotalPrice => Items.Sum(item => item.Price * item.Quantity);

        public void AddShoppingCartItems(int quantity, string color, decimal price, string productName)
        {
            var shoppingCartItem = new ShoppingCartItem(quantity, color, price, productName);
            _items.Add(shoppingCartItem);
        }
    }
}
