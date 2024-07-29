using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Users.ValueObjects;

public sealed class Email : ValueObject
{
    public const int MaxLength = 50;

    private Email(string value) => Value = value;

    public string Value { get; }

    public static Email Create(string email)
    {
        return new Email(email);    
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
