using My_App.Domain.Core.TypeBase;
namespace My_App.Domain.Users.ValueObjects;

public sealed class UserId : ValueObject
{
    public const int MaxLength = 50;

    public UserId(string value) => Value = value;

    public string Value { get; }

    public static UserId Create()
    {
        return new UserId(Guid.NewGuid().ToString());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value;
}
