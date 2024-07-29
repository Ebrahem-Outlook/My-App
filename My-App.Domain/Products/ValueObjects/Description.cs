using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Products.ValueObjects;

public sealed class Description : ValueObject
{
    public const int MaxLength = 50;

    private Description(string value) => Value = value;

    public string Value { get; }

    public static Description Create(string description)
    {
        return new Description(description);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
