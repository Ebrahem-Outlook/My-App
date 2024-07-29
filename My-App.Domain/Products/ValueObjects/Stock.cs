using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Products.ValueObjects;

public sealed class Stock : ValueObject
{
    private Stock(int value) => Value = value;

    public int Value { get; }

    public static Stock Create(int stock)
    {
        return new Stock(stock);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
