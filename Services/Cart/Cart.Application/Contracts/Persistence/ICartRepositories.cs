using Cart.Domain.Entities;

namespace Cart.Application.Contracts.Persistence
{
    public interface ICartRepository
    {
        Task<ShoppingCart> GetCart(string userName);
        Task<ShoppingCart> UpdateCart(ShoppingCart card);
        Task DeleteCart(string userName);
    }
}
