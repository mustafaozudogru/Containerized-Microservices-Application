using AutoMapper;
using EventBus.Contracts.Events;
using Ordering.Application.UseCases.Orders.Commands.CheckoutOrder;

namespace Ordering.API.Mapper
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, CartCheckoutEvent>().ReverseMap();
        }
    }
}
