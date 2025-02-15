using Domain.Models;

namespace Domain.Interfaces;

public interface IOrderHandler
{
    void SetNext(IOrderHandler nextHandler);
    void Process(Order order);
}
