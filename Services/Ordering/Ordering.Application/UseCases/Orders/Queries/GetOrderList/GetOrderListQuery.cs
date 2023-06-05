using MediatR;

namespace Ordering.Application.UseCases.Orders.Queries.GetOrderList
{
    public class GetOrderListQuery : IRequest<List<OrderDto>>
    {
    }
}
