using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Posts.ValueObjects;

public sealed class Like : ValueObject
{
    private Like(Guid userId)
    {
        UserId = userId;
        LikeDate = DateTime.UtcNow;
    }

    public Guid UserId { get; }
    public DateTime LikeDate { get; }

    public static Like Create(Guid userId)
    {
        // Add any necessary validation or logic here.
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userId));

        return new Like(userId);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return UserId;  
        yield return LikeDate;
    }
}
