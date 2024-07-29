using My_App.Domain.Core.Events;

namespace My_App.Domain.Users.Events;

public sealed record UserPasswordUpdatedDomainEvent(User User) : DomainEvent();
