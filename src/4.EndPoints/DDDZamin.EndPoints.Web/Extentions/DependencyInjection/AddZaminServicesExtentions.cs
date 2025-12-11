using DDDZamin.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace DDDZamin.EndPoints.Web.Extentions.DependencyInjection;
public static class AddZaminServicesExtensions
{
    public static IServiceCollection AddZaminUntilityServices(
        this IServiceCollection services)
    {
        services.AddTransient<ZaminServices>();
        return services;
    }
}