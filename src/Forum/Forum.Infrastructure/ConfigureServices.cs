using Forum.Application.Common.Intrefaces;
using Forum.Domain;
using Forum.Infrastructure.Common.Builders;
using Forum.Infrastructure.Persistence;
using Keycloak.AuthServices.Common;
using Keycloak.AuthServices.Sdk;
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

        services.Configure<KeycloakAdminClientOptions>(configuration.GetRequiredSection(KeycloakAdminClientOptions.Section));
        services
            .AddDistributedMemoryCache()
            .AddClientCredentialsTokenManagement()
            .AddClient(
                "adminClient",
                client =>
                {
                    var options = configuration.GetKeycloakOptions<KeycloakAdminClientOptions>();

                    client.ClientId = options.Resource;
                    client.ClientSecret = options.Credentials.Secret;
                    client.TokenEndpoint = options.KeycloakTokenEndpoint;
                }
            );

        services.AddKeycloakAdminHttpClient(configuration)
            .AddClientCredentialsTokenHandler("adminClient");

        return services;
    }
}
