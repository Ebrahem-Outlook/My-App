using My_App.Domain.Core.TypeBase;
using My_App.Domain.Products.Events;

namespace My_App.Domain.Products;

public sealed class Product : AggregateRoot
{
    private Product(Guid userId, string name, string description, decimal price, int stock)
        : base(Guid.NewGuid())
    {
        UserId = userId;
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        CreatedOn = DateTime.UtcNow;
        UpdatedOn = CreatedOn;
    }

    private Product() : base(Guid.NewGuid()) { }

    public Guid UserId { get; }
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public DateTime CreatedOn{ get; }
    public DateTime? UpdatedOn { get; private set; }

    public static Product Create(Guid userId, string name, string description, decimal price, int stock)
    {
        Product product = new(userId, name, description, price, stock);

        product.RaiseDomainEvent(new ProductCreatedDomainEvent(product));

        return product;
    }

    public void Updated(Guid userId, string name, string description, decimal price, int stock)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        UpdatedOn = DateTime.UtcNow;

        RaiseDomainEvent(new ProductUpdatedDomainEvent(this));
    }
}
