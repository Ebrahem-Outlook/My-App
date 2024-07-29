using FluentValidation;

namespace My_App.Application.Users.Commands.CreateUser;

internal sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(user => user.FirstName).NotNull().NotEmpty().WithMessage("FirstName con't be null or empty.");

        RuleFor(user => user.LastName).NotNull().NotEmpty().WithMessage("LastName con't be null or empty.");

        RuleFor(user => user.Email).NotNull().NotEmpty().WithMessage("Email con't be null or empty.");

        RuleFor(user => user.Password).NotNull().NotEmpty().WithMessage("Password con't be null or empty.");
    }
}
