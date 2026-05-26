using Microsoft.AspNetCore.Mvc;
using OrderService.Model;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    static List<string> orders = new();

    [HttpGet]
    public IActionResult GetOrders()
    {
        return Ok(orders);
    }

    [HttpPost]
    public IActionResult PlaceOrder([FromBody] Order order)
    {
        orders.Add(order.ProductName);
        return Ok("Order placed");
    }
}