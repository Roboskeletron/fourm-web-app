using FluentValidation;
using Forum.Application.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Forum.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));
        })
        .AddAutoMapper(Assembly.GetExecutingAssembly())
        .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}
