using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Users.ValueObjects;

public sealed class FirstName : ValueObject
{
    private FirstName(string value) => Value = value;

    public string Value { get; }

    public static FirstName Create(string firstName)
    {
        return new FirstName(firstName);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
