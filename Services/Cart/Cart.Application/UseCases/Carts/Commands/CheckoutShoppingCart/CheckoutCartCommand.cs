using MediatR;

namespace Cart.Application.UseCases.Carts.Commands.CheckoutShoppingCart
{
    public class CheckoutCartCommand : IRequest<Unit>
    {
        public CheckoutCartCommand(string userName, string shippingAddress)
        {
            UserName = userName;
            ShippingAddress = shippingAddress;
        }

        public string UserName { get; }

        public string ShippingAddress { get; set; }
    }
}
