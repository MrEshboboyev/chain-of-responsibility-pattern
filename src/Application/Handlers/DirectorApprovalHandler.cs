using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Handlers;

public class DirectorApprovalHandler : IOrderHandler
{
    public void SetNext(IOrderHandler nextHandler) { } // No next handler (highest level)

    public void Process(Order order)
    {
        if (order.Amount > 5000)
        {
            order.Status = OrderStatus.ApprovedByDirector;
            Console.WriteLine($"👨‍💼 Order {order.OrderId}: Approved by Director.");
        }
    }
}
