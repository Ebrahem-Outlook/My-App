using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Orders;

namespace My_App.Application.Orders.Queries.GetAll;

public sealed record GetAllOrdersQuery : IQuery<List<Order>>;

internal sealed class GetAllOrderQueryHandler : IQueryHandler<GetAllOrdersQuery, List<Order>>
{
    public Task<List<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        
    }
}