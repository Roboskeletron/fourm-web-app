using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Forum.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cnf =>
        {
            cnf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        })
        .AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}
