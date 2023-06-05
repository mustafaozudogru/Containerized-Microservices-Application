namespace Cart.Application.UseCases.Carts.Commands.UpdateShoppingCart
{
    public class UpdateCartDto
    {
        public UpdateCartDto()
        {
            Items = new List<UpdateCartItemDto>();
        }

        public string UserName { get; set; }

        public IEnumerable<UpdateCartItemDto> Items { get; set; }
    }
}
