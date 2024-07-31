using FluentValidation;

namespace My_App.Application.Users.Commands.UpdatePassword;

internal sealed class UpdatePasswordCommandValidator : AbstractValidator<UpdatePasswordCommand>
{
    public UpdatePasswordCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty.");

        RuleFor(user => user.Password).NotNull().NotEmpty().WithMessage("UserId can't be null or empty.");
    }
}
