using Cart.Application.Contracts.Persistence;
using Cart.Application.Exceptions;
using MediatR;

namespace Cart.Application.UseCases.Carts.Commands.DeleteShoppingCart
{
    public class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, Unit>
    {
        private readonly ICartRepository _cartRepository;

        public DeleteCartCommandHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository ?? throw new ArgumentNullException(nameof(cartRepository));
        }

        public async Task<Unit> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
        {
            var cartToDelete = await _cartRepository.GetCart(request.UserName);
            if (cartToDelete == null)
            {
                throw new NotFoundException(nameof(Cart), request.UserName);
            }

            await _cartRepository.DeleteCart(request.UserName);

            return Unit.Value;
        }
    }
}
