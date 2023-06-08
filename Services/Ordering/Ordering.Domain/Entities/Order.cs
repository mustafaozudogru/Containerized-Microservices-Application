using Ordering.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ordering.Domain.Entities
{
    public class Order : EntityBase
    {
        public Order()
        {

        }

        public Order(string userName, decimal totalPrice, string shippingAddress, IEnumerable<OrderItem> items)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            TotalPrice = totalPrice;
            ShippingAddress = shippingAddress ?? throw new ArgumentNullException(nameof(shippingAddress));
            Items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public string UserName { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        public virtual IEnumerable<OrderItem> Items { get; set; }
    }
}
