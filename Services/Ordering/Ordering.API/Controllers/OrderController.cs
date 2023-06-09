using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ordering.Application.UseCases.Orders.Queries.GetOrderList;
using Ordering.Application.UseCases.Orders.Queries.GetOrderListByUserName;
using Ordering.Application.UseCases.Orders.Queries.OrderQueryDto;
using System.Net;

namespace Ordering.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet(Name = "GetOrder")]
        [ProducesResponseType(typeof(IEnumerable<OrderDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders()
        => Ok(await _mediator.Send(new GetOrderListQuery()));

        [HttpGet("{userName}", Name = "GetOrderByUserName")]
        [ProducesResponseType(typeof(IEnumerable<OrderDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrdersByUserName(string userName)
        => Ok(await _mediator.Send(new GetOrderListByUserNameQuery(userName)));
    }
}
