using Domain.Enums;

namespace Domain.Models;

public class Order(int orderId, decimal amount)
{
    public int OrderId { get; set; } = orderId;
    public decimal Amount { get; set; } = amount;
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
}
