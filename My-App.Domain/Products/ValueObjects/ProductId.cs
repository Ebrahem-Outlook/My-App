using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Products.ValueObjects;

public sealed class ProductId : ValueObject
{
    private ProductId(string value) => Value = value;

    public string Value { get; }

    public static ProductId Create()
    {
        return new ProductId(Guid.NewGuid().ToString());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value;
}
