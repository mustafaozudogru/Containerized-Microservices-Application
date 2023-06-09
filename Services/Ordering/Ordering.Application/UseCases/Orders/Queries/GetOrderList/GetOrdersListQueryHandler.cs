﻿using AutoMapper;
using MediatR;
using Ordering.Application.Contracts.Persistence;
using Ordering.Application.UseCases.Orders.Queries.OrderQueryDto;

namespace Ordering.Application.UseCases.Orders.Queries.GetOrderList
{
    public class GetOrderListQueryHandler : IRequestHandler<GetOrderListQuery, IEnumerable<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrderListQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<OrderDto>> Handle(GetOrderListQuery request, CancellationToken cancellationToken)
        {
            var orderList = await _orderRepository.GetAllAsync(includeString: "Items");
            return _mapper.Map<IEnumerable<OrderDto>>(orderList);
        }
    }
}
