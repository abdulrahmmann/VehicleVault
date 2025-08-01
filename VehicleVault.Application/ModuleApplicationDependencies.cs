using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using VehicleVault.Application.Features.UserFeature.Validations;

namespace VehicleVault.Application;

public static class ModuleApplicationDependencies
{
    public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
    {
        // Register Mediator
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        
        // Register FLUENT VALIDATION
        services.AddValidatorsFromAssemblyContaining<RegisterUserValidator>();
        
        return services;
    }
}