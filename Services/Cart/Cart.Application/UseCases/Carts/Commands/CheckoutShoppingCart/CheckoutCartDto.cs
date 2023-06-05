namespace Cart.Application.UseCases.Carts.Commands.CheckoutShoppingCart
{
    public class CheckoutCartDto
    {
        public CheckoutCartDto(string userName, string shippingAddress)
        {
            UserName = userName;
            ShippingAddress = shippingAddress;
        }

        public string UserName { get; set; }

        public string ShippingAddress { get; set; }
    }
}
