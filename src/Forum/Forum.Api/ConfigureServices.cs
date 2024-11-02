using Forum.Api.Middlewares;
using Forum.Api.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Forum.Api;
public static class ConfigureServices
{
    public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthorization(configuration);

        return services;
    }

    public static IServiceCollection AddAuthorization(this IServiceCollection services, IConfiguration configuration)
    {
        var authOptions = configuration
            .GetRequiredSection(AuthOptions.SectionName)
            .Get<AuthOptions>() ?? throw new InvalidOperationException($"{AuthOptions.SectionName} is not configured");

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.MapInboundClaims = false;
            options.RequireHttpsMetadata = !authOptions.EnableUnsafeAuth;

            options.Audience = authOptions.Audience;
            options.Authority = authOptions.Authority;

            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidIssuer = authOptions.Authority,
                ValidateLifetime = authOptions.ValidateLifetime,
            };
        });

        services.AddAuthorization();

        services.AddScoped<UserProviderInitiatorMiddleware>();

        return services;
    }
}
