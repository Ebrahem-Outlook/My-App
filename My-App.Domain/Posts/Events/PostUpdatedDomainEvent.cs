using My_App.Domain.Core.Events;

namespace My_App.Domain.Posts.Events;

public sealed record PostUpdatedDomainEvent(Post Post) : DomainEvent();
