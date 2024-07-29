using My_App.Domain.Core.TypeBase;
using My_App.Domain.Posts.Events;
using My_App.Domain.Posts.ValueObjects;

namespace My_App.Domain.Posts;

/// <summary>
/// 
/// </summary>
public sealed class Post : AggregateRoot
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="title"></param>
    /// <param name="content"></param>
    /// <param name="authorId"></param>
    /// <param name="likes"></param>
    /// <param name="comments"></param>
    private Post(string title, string content, Guid authorId, List<Like> likes, List<Comment> comments)
        : base(Guid.NewGuid())
    {
        Title = title;
        Content = content;
        AuthorId = authorId;
        CreatedOn = DateTime.UtcNow;
        UpdatedOn = CreatedOn;
        _likes = likes;
        _comments = comments;
    }

    private Post() : base() { }

    /// <summary>
    /// 
    /// </summary>
    public string Title { get; private set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public string Content { get; private set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public Guid AuthorId { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreatedOn { get; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime? UpdatedOn { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public bool IsUpdated { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    private readonly List<Like> _likes = [];
    public IReadOnlyCollection<Like> Likes => _likes.AsReadOnly();

    /// <summary>
    /// 
    /// </summary>
    private readonly List<Comment> _comments = [];
    public IReadOnlyCollection<Comment> Comments => _comments.AsReadOnly();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="title"></param>
    /// <param name="content"></param>
    /// <param name="authorId"></param>
    /// <param name="likes"></param>
    /// <param name="comments"></param>
    /// <returns></returns>
    public static Post Create(string title, string content, Guid authorId, List<Like> likes, List<Comment> comments)
    {
        Post post = new(title, content, authorId, likes, comments);

        post.RaiseDomainEvent(new PostCreatedDomainEvent(post));

        return post;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    public void Update(string content)
    {
        Content = content;
        UpdatedOn = DateTime.UtcNow;
        IsUpdated = true;

        RaiseDomainEvent(new PostUpdatedDomainEvent(this));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="comment"></param>
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);

        RaiseDomainEvent(new NewCommentDomainEvent(comment));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="like"></param>
    public void AddLike(Like like)
    {
        _likes.Add(like);

        RaiseDomainEvent(new NewLikeDomainEvent(like));
    }
}
