using MediatR;
using Ordering.Application.UseCases.Orders.Queries.OrderQueryDto;

namespace Ordering.Application.UseCases.Orders.Queries.GetOrderListByUserName
{
    public class GetOrderListByUserNameQuery : IRequest<IEnumerable<OrderDto>>
    {
        public string UserName { get; set; }

        public GetOrderListByUserNameQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}
