using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Products.ValueObjects;

public sealed class Name : ValueObject
{
    public const int MaxLength = 50;

    private Name(string value) => Value = value;

    public string Value { get; }

    public static Name Create(string name)
    {
        return new Name(name);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
