using FluentValidation;

namespace My_App.Application.Users.Commands.UpdateEmail;

internal sealed class UpdateEmailCommandValidator : AbstractValidator<UpdateEmailCommand>
{
    public UpdateEmailCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty.");

        RuleFor(user => user.Email).NotNull().NotEmpty().WithMessage("UserId can't be null or empty.");
    }
}
