using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Posts.ValueObjects;

public sealed class PostId : ValueObject
{
    private PostId(string value) => Value = value;

    public string Value { get; }

    public static PostId Create()
    {
        return new PostId(Guid.NewGuid().ToString());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value;
}
