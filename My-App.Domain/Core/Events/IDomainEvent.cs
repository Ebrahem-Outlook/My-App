using MediatR;

namespace My_App.Domain.Core.Events;

public interface IDomainEvent : IEvent
{
    Guid Id { get; }

    DateTime OcurredOn { get; }
}
