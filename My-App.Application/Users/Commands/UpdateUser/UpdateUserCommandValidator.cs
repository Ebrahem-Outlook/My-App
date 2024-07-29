using FluentValidation;

namespace My_App.Application.Users.Commands.UpdateUser;

internal sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(user => user.FirstName).NotNull().NotEmpty().WithMessage("FirstName of user can't be null");

        RuleFor(user => user.LastName).NotNull().NotEmpty().WithMessage("FirstName of user can't be null");
    }
}
