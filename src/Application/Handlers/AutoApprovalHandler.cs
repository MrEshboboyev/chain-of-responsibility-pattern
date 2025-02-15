using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Handlers;

public class AutoApprovalHandler : IOrderHandler
{
    private IOrderHandler _nextHandler;

    public void SetNext(IOrderHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public void Process(Order order)
    {
        if (order.Amount < 1000)
        {
            order.Status = OrderStatus.ApprovedBySystem;
            Console.WriteLine($"🔹 Order {order.OrderId}: Auto-approved.");
        }
        else
        {
            Console.WriteLine($"🔸 Order {order.OrderId}: Forwarded to Manager...");
            _nextHandler?.Process(order);
        }
    }
}
