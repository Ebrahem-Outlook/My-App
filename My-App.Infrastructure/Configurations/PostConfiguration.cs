using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_App.Domain.Posts;

namespace My_App.Infrastructure.Configurations;

internal sealed class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("Post");

        builder.HasKey(post => post.Id);

        builder.Property(post => post.Content)
            .HasColumnName("Post_Content")
            .HasColumnType("varchar(255)")
            .IsRequired(true);

        builder.Property(post => post.)
            .HasColumnName("Post_Content")
            .HasColumnType("varchar(255)")
            .IsRequired(true);

        builder.Property(post => post.Content)
            .HasColumnName("Post_Content")
            .HasColumnType("varchar(255)")
            .IsRequired(true);

        builder.Property(post => post.Content)
            .HasColumnName("Post_Content")
            .HasColumnType("varchar(255)")
            .IsRequired(true);
    }
}