using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using My_App.Application.Core.Abstractions.Data;
using My_App.Domain.Orders;
using My_App.Domain.Posts;
using My_App.Domain.Products;
using My_App.Domain.Users;
using My_App.Infrastructure.Database;
using My_App.Infrastructure.Repositories;

namespace My_App.Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Db Context....
        services.AddDbContext<AppDbContext>(options =>
        {
            string? connection = configuration.GetConnectionString("Postgres");

            options.UseNpgsql(connection);
        });

        services.AddScoped<IDbContext>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());

        services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());

        // Services...
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddScoped<IPostRepository, PostRepository>();

        services.AddScoped<IOrderRepository, OrderRepository>();


        // Caching...

        services.AddDistributedMemoryCache();




        return services;
    }
}
