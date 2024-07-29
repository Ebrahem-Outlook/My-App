namespace My_App.Domain.Core.Events;

public abstract record DomainEvent : IDomainEvent
{
    public DomainEvent() 
        : this (Guid.NewGuid(), DateTime.UtcNow)
    {

    }

    protected DomainEvent(Guid id, DateTime ocurredOn)
    {
        Id = id;
        OcurredOn = ocurredOn;
    }

    public Guid Id { get; }

    public DateTime OcurredOn { get; }
}
