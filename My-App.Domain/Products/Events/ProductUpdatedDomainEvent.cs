using My_App.Domain.Core.Events;

namespace My_App.Domain.Products.Events;

public sealed record ProductUpdatedDomainEvent(Product Product) : DomainEvent();
