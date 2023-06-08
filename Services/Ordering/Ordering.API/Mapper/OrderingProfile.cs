using AutoMapper;
using EventBus.Contracts.Events;
using Ordering.Application.UseCases.Orders.Commands.CreateOrder;

namespace Ordering.API.Mapper
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CreateOrderCommand, CartCheckoutEvent>().ReverseMap();
            CreateMap<ShoppingCartItemDto, ShoppingCartItem>().ReverseMap();
        }
    }
}
