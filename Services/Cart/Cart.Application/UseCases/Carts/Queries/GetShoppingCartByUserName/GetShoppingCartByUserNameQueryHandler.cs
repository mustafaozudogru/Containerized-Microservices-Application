using AutoMapper;
using Cart.Application.Contracts.Persistence;
using MediatR;

namespace Cart.Application.UseCases.Carts.Queries.GetShoppingCartByUserName
{
    public class GetShoppingCartByUsernameQueryQueryHandler : IRequestHandler<GetShoppingCartByUserNameQuery, ShoppingCartDto>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public GetShoppingCartByUsernameQueryQueryHandler(ICartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository ?? throw new ArgumentNullException(nameof(cartRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ShoppingCartDto> Handle(GetShoppingCartByUserNameQuery request, CancellationToken cancellationToken)
        {
            var shoppingCart = await _cartRepository.GetCart(request.UserName);

            return _mapper.Map<ShoppingCartDto>(shoppingCart);
        }
    }
}
