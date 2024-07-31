using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Orders;

namespace My_App.Application.Orders.Queries.GetByUserId;

internal class GetByAutherIdQuery : IQuery<List<Order>>
{
}
