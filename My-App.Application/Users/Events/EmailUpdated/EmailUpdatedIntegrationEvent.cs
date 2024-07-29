using My_App.Application.Core.Abstractions.Events;

namespace My_App.Application.Users.Events.EmailUpdated;

public sealed record EmailUpdatedIntegrationEvent() : IIntegrationEvent;
