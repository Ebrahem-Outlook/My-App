using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_App.Domain.Products;

namespace My_App.Infrastructure.Configurations;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // Specify the table name
        builder.ToTable("Product");

        // Define the primary key
        builder.HasKey(product => product.Id);

        // Configure the Name property
        builder.Property(product => product.Name)
            .HasColumnName("Product_Name")
            .HasColumnType("varchar(50)")
            .IsRequired();

        // Configure the Description property
        builder.Property(product => product.Description)
            .HasColumnName("Product_Description")
            .HasColumnType("varchar(255)")
            .IsRequired();

        // Configure the Price property
        builder.Property(product => product.Price)
            .HasColumnName("Product_Price")
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        // Configure the Stock property
        builder.Property(product => product.Stock)
            .HasColumnName("Product_Stock")
            .HasColumnType("int") // Changed to numeric type
            .IsRequired();

        // Configure the CreatedOn property
        builder.Property(product => product.CreatedOn)
            .HasColumnName("Product_CreatedOn")
            .HasColumnType("datetime")
            .IsRequired();

        // Configure the UpdatedOn property
        builder.Property(product => product.UpdatedOn)
            .HasColumnName("Product_UpdatedOn")
            .HasColumnType("datetime")
            .IsRequired(false);
    }
}
