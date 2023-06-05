using Cart.Application.Contracts.Persistence;
using Cart.Domain.Entities;
using MediatR;

namespace Cart.Application.UseCases.Carts.Commands.UpdateShoppingCart
{
    public class UpdateCartCommandHandler : IRequestHandler<UpdateCartCommand, Unit>
    {
        private readonly ICartRepository _cartRepository;

        public UpdateCartCommandHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository ?? throw new ArgumentNullException(nameof(cartRepository));
        }

        public async Task<Unit> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
        {
            var shoppingCart = new ShoppingCart(request.UserName);

            foreach (var item in request.Items)
            {
                shoppingCart.AddShoppingCartItems(item.Quantity, item.Color, item.Price, item.ProductName);
            }

            await _cartRepository.UpdateCart(shoppingCart);
            
            return Unit.Value;
        }
    }
}
