using MediatR;

namespace Ordering.Application.UseCases.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderCommand : IRequest<int>
    {
        public CheckoutOrderCommand(string userName, decimal totalPrice, string shippingAddress)
        {
            UserName = userName;
            TotalPrice = totalPrice;
            ShippingAddress = shippingAddress;
        }

        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
    }
}
