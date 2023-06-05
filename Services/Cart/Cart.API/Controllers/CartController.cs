using Microsoft.AspNetCore.Mvc;
using MediatR;
using Cart.Application.UseCases.Carts.Commands.CheckoutShoppingCart;
using Cart.Application.UseCases.Carts.Commands.UpdateShoppingCart;
using Cart.Application.UseCases.Carts.Commands.DeleteShoppingCart;
using Cart.Application.UseCases.Carts.Queries.GetShoppingCartByUserName;

namespace Cart.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CartController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        [Route("{username}")]
        [ProducesResponseType(typeof(ShoppingCartDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ShoppingCartDto>> GetShoppingCartAsync(string username)
            => Ok(await _mediator.Send(new GetShoppingCartByUserNameQuery(username)));

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public async Task<IActionResult> CheckoutAsync([FromBody] CheckoutCartDto cart)
        {
            await _mediator.Send(new CheckoutCartCommand(cart.UserName,
                cart.ShippingAddress));
            return Accepted();
        }

        [HttpPut]
        [Route("update")]
        [ProducesResponseType(typeof(ShoppingCartDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<ShoppingCartDto>> UpdateShoppingCartAsync([FromBody] UpdateCartDto cart)
            => Ok(await _mediator.Send(new UpdateCartCommand(cart.UserName, cart.Items)));

        [HttpDelete]
        [Route("{username}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteShoppingCartAsync(string username)
            => Ok(await _mediator.Send(new DeleteCartCommand(username)));
    }
}