using FluentValidation;

namespace My_App.Application.Users.Queries.GetByName;

internal sealed class GetUserByNameQueryValidator : AbstractValidator<GetUserByNameQuery>
{
    public GetUserByNameQueryValidator()
    {
        RuleFor(user => user.Name).NotNull().NotEmpty().WithMessage("Name can't be null or empty");
    }
}
