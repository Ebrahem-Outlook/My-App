using My_App.Domain.Core.Events;

namespace My_App.Domain.Core.TypeBase;

public abstract class AggregateRoot<TId> : Entity<TId>, IAggregateRoot<TId>
{
    protected AggregateRoot(TId id) : base(id) { }

    protected AggregateRoot() : base() { }

    private readonly List<IDomainEvent> domainEvents = [];

    public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.AsReadOnly();

    public void RaiseDomainEvent(IDomainEvent @event) => domainEvents.Add(@event);

    public void ClearDomainEvents() => domainEvents.Clear();
}

public interface IAggregateRoot<TId>
{
    TId Id { get; }

    void RaiseDomainEvent(IDomainEvent @event);

    void ClearDomainEvents();
}
