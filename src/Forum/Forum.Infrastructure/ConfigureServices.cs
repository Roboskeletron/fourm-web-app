using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Infrastructure.Common.Builders;
using Forum.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.Infrastructure;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("postgres")
                ?? throw new InvalidOperationException("Connection string for postgres is not provided");

            options.UseNpgsql(connectionString);
        });

        services
            .AddScoped<IApplicationDbContext, ApplicationDbContext>()
            .AddScoped<IUserProviderBuilder, UserProviderBuilder>()
            .AddTransient(sp => sp.GetRequiredService<IUserProviderBuilder>().Build());

        return services;
    }
}
