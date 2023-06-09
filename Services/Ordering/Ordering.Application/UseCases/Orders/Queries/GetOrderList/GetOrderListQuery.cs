using MediatR;
using Ordering.Application.UseCases.Orders.Queries.OrderQueryDto;

namespace Ordering.Application.UseCases.Orders.Queries.GetOrderList
{
    public class GetOrderListQuery : IRequest<IEnumerable<OrderDto>>
    {
    }
}
