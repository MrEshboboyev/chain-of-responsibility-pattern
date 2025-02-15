using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Handlers;

public class ManagerApprovalHandler : IOrderHandler
{
    private IOrderHandler _nextHandler;

    public void SetNext(IOrderHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public void Process(Order order)
    {
        if (order.Amount >= 1000 && order.Amount <= 5000)
        {
            order.Status = OrderStatus.ApprovedByManager;
            Console.WriteLine($"👨‍💼 Order {order.OrderId}: Approved by Manager.");
        }
        else
        {
            Console.WriteLine($"🔸 Order {order.OrderId}: Forwarded to Director...");
            _nextHandler?.Process(order);
        }
    }
}
