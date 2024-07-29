﻿using MediatR;

namespace My_App.Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid Id { get; }

    DateTime OcurredOn { get; }
}
