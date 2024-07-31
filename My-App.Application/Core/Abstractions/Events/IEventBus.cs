using My_App.Domain.Core.Events;

namespace My_App.Application.Core.Abstractions.Events;

public interface IEventBus
{
    Task PublishAsync<TEvent>(TEvent @event) where TEvent : IDomainEvent;
    Task SubscribeAsync<TEvent>(TEvent @event) where TEvent : IDomainEvent;
}
