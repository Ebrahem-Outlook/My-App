using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Users.ValueObjects;

public sealed class Password : ValueObject
{
    public const int MaxLength = 50;

    private Password(string value) => Value = value;    

    public string Value { get; }

    public static Password Create(string password)
    {
        return new Password(password);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
