namespace Cart.Application.UseCases.Carts.Queries.GetShoppingCartByUserName
{
    public class ShoppingCartDto
    {
        public ShoppingCartDto(string userName, decimal totalPrice, IEnumerable<ShoppingCartItemDto> items)
        {
            UserName = userName;
            TotalPrice = totalPrice;
            Items = items;
        }

        public string UserName { get; set; }

        public decimal TotalPrice { get; set; }

        public IEnumerable<ShoppingCartItemDto> Items { get; set; }
    }
}
