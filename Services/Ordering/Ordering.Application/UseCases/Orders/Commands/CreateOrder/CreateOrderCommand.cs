using MediatR;

namespace Ordering.Application.UseCases.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<int>
    {
        public CreateOrderCommand(string userName, decimal totalPrice, string shippingAddress, IEnumerable<ShoppingCartItemDto> items)
        {
            UserName = userName;
            TotalPrice = totalPrice;
            ShippingAddress = shippingAddress;
            Items = items;
        }

        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        public IEnumerable<ShoppingCartItemDto> Items { get; set; }
    }
}
