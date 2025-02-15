using Application.Handlers;
using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Services;

public class OrderApprovalService
{
    private readonly IOrderHandler _approvalChain;

    public OrderApprovalService()
    {
        var autoApproval = new AutoApprovalHandler();
        var managerApproval = new ManagerApprovalHandler();
        var directorApproval = new DirectorApprovalHandler();

        autoApproval.SetNext(managerApproval);
        managerApproval.SetNext(directorApproval);

        _approvalChain = autoApproval;
    }

    public void ProcessOrder(Order order)
    {
        _approvalChain.Process(order);
    }
}
