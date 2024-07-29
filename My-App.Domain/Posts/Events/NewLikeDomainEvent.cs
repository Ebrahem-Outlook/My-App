using My_App.Domain.Core.Events;
using My_App.Domain.Posts.ValueObjects;

namespace My_App.Domain.Posts.Events;

public sealed record NewLikeDomainEvent(Like Like) : DomainEvent();
