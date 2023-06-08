using Ordering.Domain.Common;

namespace Ordering.Domain.Entities
{
    public class OrderItem : EntityBase
    {
        public OrderItem(int quantity,string color, decimal price, string productName)
        {
            Quantity = quantity;
            Color = color;
            Price = price;
            ProductName = productName;
        }

        public int Quantity { get; protected set; }

        public string Color { get; set; }

        public decimal Price { get; protected set; }

        public string ProductName { get; protected set; }

        public virtual Order Order { get; protected set; }
    }
}
