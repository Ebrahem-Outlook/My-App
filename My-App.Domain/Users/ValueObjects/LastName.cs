using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Users.ValueObjects;

public sealed class LastName : ValueObject
{
    public const int MaxLength = 50;

    private LastName(string value) => Value = value;

    public string Value { get; }

    public static LastName Create(string lastName)
    {
        return new(lastName);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value; 
    }
}
