using AutoMapper;
using MediatR;
using Ordering.Application.Contracts.Persistence;
using Ordering.Application.UseCases.Orders.Queries.OrderQueryDto;

namespace Ordering.Application.UseCases.Orders.Queries.GetOrderListByUserName
{
    public class GetOrderListByUserNameQueryHandler : IRequestHandler<GetOrderListByUserNameQuery, IEnumerable<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrderListByUserNameQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<OrderDto>> Handle(GetOrderListByUserNameQuery request, CancellationToken cancellationToken)
        {
            var orderList = await _orderRepository.GetOrdersByUserName(request.UserName);
            return _mapper.Map<IEnumerable<OrderDto>>(orderList);
        }
    }
}
