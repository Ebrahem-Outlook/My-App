using My_App.Domain.Core.TypeBase;

namespace My_App.Domain.Posts.ValueObjects;

public sealed class Comment : ValueObject
{
    private Comment(Guid id, Guid userId, string content)
    {
        Id = id;
        UserId = userId;
        Content = content;
        CommentedDate = DateTime.UtcNow;
    }

    public Guid Id { get; }
    public Guid UserId { get; }
    public string Content { get; }
    public DateTime CommentedDate { get; }
    
    public static Comment Create(Guid id, Guid userId, string content)
    {
        // Add any necessary validation or logic here
        if (id == Guid.Empty)
            throw new ArgumentException("Id cannot be empty.", nameof(id));
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty.", nameof(userId));
        if (string.IsNullOrWhiteSpace(content))
            throw new ArgumentException("Content cannot be empty.", nameof(content));


        return new(id, userId, content);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
        yield return UserId;
        yield return Content;
        yield return CommentedDate;
    }
}
