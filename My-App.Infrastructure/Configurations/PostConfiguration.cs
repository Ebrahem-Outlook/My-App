using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_App.Domain.Posts;

namespace My_App.Infrastructure.Configurations
{
    internal sealed class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");

            // Primary key
            builder.HasKey(post => post.Id);

            // Properties configuration
            builder.Property(post => post.Title)
                .HasColumnName("Title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(post => post.Content)
                .HasColumnName("Content")
                .HasColumnType("varchar(1000)") // Adjust as needed
                .IsRequired();

            builder.Property(post => post.AuthorId)
                .HasColumnName("AuthorId")
                .IsRequired();

            builder.Property(post => post.CreatedOn)
                .HasColumnName("CreatedOn")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(post => post.UpdatedOn)
                .HasColumnName("UpdatedOn")
                .HasColumnType("datetime");

            builder.Property(post => post.IsUpdated)
                .HasColumnName("IsUpdated")
                .IsRequired();
        }
    }
}
