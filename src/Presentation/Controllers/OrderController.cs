using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Infrastructure.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderApprovalService _orderService;

    public OrderController()
    {
        _orderService = new OrderApprovalService();
    }

    [HttpPost("process")]
    public IActionResult ProcessOrder([FromBody] Order order)
    {
        _orderService.ProcessOrder(order);
        return Ok($"Order {order.OrderId} Status: {order.Status}");
    }
}
