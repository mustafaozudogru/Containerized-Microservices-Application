using AutoMapper;
using Cart.Application.UseCases.Carts.Queries.GetShoppingCartByUserName;
using Cart.Domain.Entities;

namespace Cart.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ShoppingCartItem, ShoppingCartItemDto>();

            CreateMap<ShoppingCart, ShoppingCartDto>().ReverseMap();
        }
    }
}
