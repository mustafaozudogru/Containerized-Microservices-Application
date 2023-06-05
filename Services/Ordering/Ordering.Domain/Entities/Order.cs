using Ordering.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ordering.Domain.Entities
{
    public class Order : EntityBase
    {
        public Order(string userName, decimal totalPrice, string shippingAddress)
        {
            UserName = userName;
            TotalPrice = totalPrice;
            ShippingAddress = shippingAddress;
        }

        public string UserName { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
    }
}
