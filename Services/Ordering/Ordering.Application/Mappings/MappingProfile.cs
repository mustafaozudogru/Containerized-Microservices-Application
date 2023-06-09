using AutoMapper;
using Ordering.Application.UseCases.Orders.Commands.CreateOrder;
using Ordering.Application.UseCases.Orders.Queries.OrderQueryDto;
using Ordering.Domain.Entities;

namespace Ordering.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, CreateOrderCommand>().ReverseMap();
            CreateMap<ShoppingCartItemDto, OrderItem>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        }
    }
}
