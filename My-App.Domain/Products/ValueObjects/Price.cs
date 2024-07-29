using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Products.ValueObjects;

public sealed class Price : ValueObject
{
    private Price(int value) => Value = value;

    public int Value { get; }

    public static Price Create(int price)
    {
        return new Price(price);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}
