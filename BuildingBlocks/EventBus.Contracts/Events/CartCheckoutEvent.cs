namespace EventBus.Contracts.Events
{
    public class CartCheckoutEvent : BaseEvent
    {
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }

        public IEnumerable<ShoppingCartItem> Items { get; set; }
    }
}
