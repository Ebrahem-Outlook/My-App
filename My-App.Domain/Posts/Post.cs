using System;
using System.Collections.Generic;
using My_App.Domain.Core.TypeBase;
using My_App.Domain.Posts.Events;
using My_App.Domain.Posts.ValueObjects;
using My_App.Domain.Users;

namespace My_App.Domain.Posts
{
    public sealed class Post : AggregateRoot<PostId>
    {
        // Private constructor for creating a Post
        private Post(string title, string content, Guid authorId, List<Guid> likeIds, List<Guid> commentIds)
            : base(PostId.Create())
        {
            Title = title;
            Content = content;
            AuthorId = authorId;
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = CreatedOn;
            _likeIds = likeIds;
            _commentIds = commentIds;
        }

        // Parameterless constructor for Entity Framework
        private Post() : base() { }

        public string Title { get; private set; } = default!;
        public string Content { get; private set; } = default!;
        public Guid AuthorId { get; private set; }
        public DateTime CreatedOn { get; }
        public DateTime? UpdatedOn { get; private set; }
        public bool IsUpdated { get; private set; }

        // Lists of foreign key IDs for likes and comments
        private readonly List<Guid> _likeIds = new List<Guid>();
        public IReadOnlyCollection<Guid> LikeIds => _likeIds.AsReadOnly();

        private readonly List<Guid> _commentIds = new List<Guid>();
        public IReadOnlyCollection<Guid> CommentIds => _commentIds.AsReadOnly();

        private readonly List<Guid> _sharedByUserIds = new List<Guid>();
        public IReadOnlyCollection<Guid> SharedByUserIds => _sharedByUserIds.AsReadOnly();

        // Factory method to create a new Post
        public static Post Create(string title, string content, Guid authorId, List<Guid> likeIds, List<Guid> commentIds)
        {
            Post post = new(title, content, authorId, likeIds, commentIds);
            post.RaiseDomainEvent(new PostCreatedDomainEvent(post));
            return post;
        }

        // Method to update the post content
        public void Update(string content)
        {
            Content = content;
            UpdatedOn = DateTime.UtcNow;
            IsUpdated = true;
            RaiseDomainEvent(new PostUpdatedDomainEvent(this));
        }

        // Method to add a comment (by comment ID)
        public void AddComment(Guid commentId)
        {
            if (!_commentIds.Contains(commentId))
            {
                _commentIds.Add(commentId);
                RaiseDomainEvent(new NewCommentDomainEvent(commentId));
            }
        }

        // Method to add a like (by like ID)
        public void AddLike(Guid likeId)
        {
            if (!_likeIds.Contains(likeId))
            {
                _likeIds.Add(likeId);
                RaiseDomainEvent(new NewLikeDomainEvent(likeId));
            }
        }

        // Method to add a user who shared the post (by user ID)
        public void AddShare(Guid userId)
        {
            if (!_sharedByUserIds.Contains(userId))
            {
                _sharedByUserIds.Add(userId);
            }
        }
    }
}
