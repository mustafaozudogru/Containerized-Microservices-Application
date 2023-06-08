using Cart.Application.Contracts.Persistence;
using Cart.Application.Exceptions;
using EventBus.Contracts.Events;
using MassTransit;
using MediatR;

namespace Cart.Application.UseCases.Carts.Commands.CheckoutShoppingCart
{
    public class CheckoutCartCommandHandler : IRequestHandler<CheckoutCartCommand, Unit>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IPublishEndpoint _publishEndpoint;

        public CheckoutCartCommandHandler(ICartRepository cartRepository, IPublishEndpoint publishEndpoint)
        {
            _cartRepository = cartRepository ?? throw new ArgumentNullException(nameof(cartRepository));
            _publishEndpoint = publishEndpoint ?? throw new ArgumentNullException(nameof(publishEndpoint));
        }

        public async Task<Unit> Handle(CheckoutCartCommand request, CancellationToken cancellationToken)
        {
            var shoppingCart = await _cartRepository.GetCart(request.UserName);
            if (shoppingCart == null)
                throw new NotFoundException(nameof(Cart), request.UserName);

            await _publishEndpoint.Publish<CartCheckoutEvent>(new
            {
                request.UserName,
                shoppingCart.TotalPrice,
                request.ShippingAddress,
                shoppingCart?.Items
            }, cancellationToken);

            await _cartRepository.DeleteCart(request.UserName);

            return Unit.Value;
        }
    }
}
