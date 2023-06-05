using MediatR;

namespace Cart.Application.UseCases.Carts.Commands.UpdateShoppingCart
{
    public class UpdateCartCommand : IRequest<Unit>
    {
        public UpdateCartCommand(string userName, IEnumerable<UpdateCartItemDto> items)
        {
            UserName = userName;
            Items = items;
        }

        public string UserName { get; }

        public IEnumerable<UpdateCartItemDto> Items { get; }
    }
}
