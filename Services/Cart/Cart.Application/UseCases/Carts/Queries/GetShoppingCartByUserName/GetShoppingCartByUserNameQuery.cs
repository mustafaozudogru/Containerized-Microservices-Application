using MediatR;

namespace Cart.Application.UseCases.Carts.Queries.GetShoppingCartByUserName
{
    public class GetShoppingCartByUserNameQuery : IRequest<ShoppingCartDto>
    {
        public GetShoppingCartByUserNameQuery(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; }
    }
}
