using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order("mustafaozudogru", 100, "Turkey", GetPreconfiguredOrderItems())
            };
        }

        private static IEnumerable<OrderItem> GetPreconfiguredOrderItems()
        {
            return new List<OrderItem>
            {
                new OrderItem(1,"Blue", 1.5M, "Item1"),
                new OrderItem(2,"Red", 1M, "Item2")
        };
        }
    }
}
