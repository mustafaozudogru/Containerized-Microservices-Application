using MediatR;

namespace Cart.Application.UseCases.Carts.Commands.DeleteShoppingCart
{
    public class DeleteCartCommand : IRequest<Unit>
    {
        public DeleteCartCommand(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; }
    }
}
