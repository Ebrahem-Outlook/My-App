﻿using My_App.Domain.Core.TypeBase;
using My_App.Domain.Users.Events;

namespace My_App.Domain.Users;

public sealed class User : AggregateRoot<Guid>
{
    private User(string firstName, string lastName, string email, string password)
        : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    private User() : base() { }

    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string Password { get; private set; } = default!;

    public static User Create(string firstName, string lastName, string email, string password)
    {
        User user = new(firstName, lastName, email, password);

        user.RaiseDomainEvent(new UserCreatedDomainEvent(user));

        return user;
    }

    public void Update(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        RaiseDomainEvent(new UserUpdatedDomainEvent(this));
    }

    public void UpdateEmail(string email)
    {
        Email = email;

        RaiseDomainEvent(new UserEmailUpdatedDomainEvent(this));
    }

    public void UpdatePassword(string password)
    {
        Password = password;

        RaiseDomainEvent(new UserPasswordUpdatedDomainEvent(this));
    }
}

