using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using My_App.Application.Core.Abstractions.Authentication;
using My_App.Application.Core.Abstractions.Data;
using My_App.Application.Core.Abstractions.Emails;
using My_App.Domain.Orders;
using My_App.Domain.Posts;
using My_App.Domain.Products;
using My_App.Domain.Users;
using My_App.Infrastructure.Authentication;
using My_App.Infrastructure.Authentication.Settings;
using My_App.Infrastructure.Database;
using My_App.Infrastructure.Emails;
using My_App.Infrastructure.Repositories;
using System.Text;

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

        services.AddScoped<IJwtProvider, JwtProvider>();


        // Configurations...
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SettingsKey));

        

        // Caching...

        services.AddDistributedMemoryCache();


        // Jwt...Configuration.
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(configuration["Jwt:SecurityKey"]))
                });


        // Email...Configuration.
        var emailConfig = configuration.GetSection("EmailSettings");
        services.AddSingleton<IEmailService>(sp => new EmailService(
            emailConfig["Host"],
            int.Parse(emailConfig["Port"]),
            emailConfig["From"],
            emailConfig["Username"],
            emailConfig["Password"]
        ));

        return services;
    }
}
