using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace VehicleVault.Application;

public static class ModuleApplicationDependencies
{
    public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
    {
        // Register Mediator
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        
        // Register FLUENT VALIDATION

        
        return services;
    }
}