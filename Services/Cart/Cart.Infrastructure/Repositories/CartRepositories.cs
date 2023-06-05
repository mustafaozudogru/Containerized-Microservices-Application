using Cart.Application.Contracts.Persistence;
using Cart.Domain.Entities;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Cart.Infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly IDistributedCache _redisCache;

        public CartRepository(IDistributedCache cache)
        {
            _redisCache = cache ?? throw new ArgumentNullException(nameof(cache));
        }

        public async Task<ShoppingCart> GetCart(string userName)
        {
            var card = await _redisCache.GetStringAsync(userName);

            if (String.IsNullOrEmpty(card))
                return null;

            return JsonConvert.DeserializeObject<ShoppingCart>(card);
        }

        public async Task<ShoppingCart> UpdateCart(ShoppingCart card)
        {
            await _redisCache.SetStringAsync(card.UserName, JsonConvert.SerializeObject(card));

            return await GetCart(card.UserName);
        }

        public async Task DeleteCart(string userName)
        {
            await _redisCache.RemoveAsync(userName);
        }
    }
}
