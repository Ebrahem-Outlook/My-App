using FluentValidation;

namespace My_App.Application.Users.Queries.GetByEmail;

internal sealed class GetUserByEmailQueryValidator : AbstractValidator<GetUserByEmailQuery>
{
    public GetUserByEmailQueryValidator()
    {
        RuleFor(user => user.Email).NotNull().NotEmpty().WithMessage("Email Can't be null or empty");
    }
}
