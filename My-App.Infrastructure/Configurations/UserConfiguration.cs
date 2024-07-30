using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_App.Domain.Users;

namespace My_App.Infrastructure.Configurations;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Specify the table name
        builder.ToTable("Users");

        // Define the primary key
        builder.HasKey(user => user.Id);

        // Configure the FirstName property
        builder.Property(user => user.FirstName)
            .HasColumnName("FirstName")
            .HasColumnType("varchar(50)")
            .IsRequired();

        // Configure the LastName property
        builder.Property(user => user.LastName)
            .HasColumnName("LastName")
            .HasColumnType("varchar(50)")
            .IsRequired();

        // Configure the Email property
        builder.Property(user => user.Email)
            .HasColumnName("Email")
            .HasColumnType("varchar(50)")
            .IsRequired();

        // Configure the Password property
        builder.Property(user => user.Password)
            .HasColumnName("HashPasword") 
            .HasColumnType("varchar(50)")
            .IsRequired();
    }
}
