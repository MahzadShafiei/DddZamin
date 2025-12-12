using DDDZamin.EndPoints.Web.Filters;
using DDDZamin.EndPoints.Web.Middlewares.ApiExceptionHandler;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DDDZamin.EndPoints.Web.Extentions.DependencyInjection;

public static class AddApiConfigurationExtensions
{
    public static IServiceCollection AddZaminApiCore(this IServiceCollection services, params string[] assemblyNamesForLoad)
    {
        services.AddControllers(delegate (MvcOptions options)
        {
            options.Filters.Add<PascalCaseJsonFilter>();
            options.Filters.Add<CamelCaseJsonFilter>();
        }).AddFluentValidation();
        services.AddZaminDependencies(assemblyNamesForLoad);

        return services;
    }

    public static void UseZaminApiExceptionHandler(this IApplicationBuilder app)
    {

        app.UseApiExceptionHandler(options =>
        {
            options.AddResponseDetails = (context, ex, error) =>
            {
                if (ex.GetType().Name == typeof(Microsoft.Data.SqlClient.SqlException).Name)
                {
                    error.Detail = "Exception was a database exception!";
                }
            };
            options.DetermineLogLevel = ex =>
            {
                if (ex.Message.StartsWith("cannot open database", StringComparison.InvariantCultureIgnoreCase) ||
                    ex.Message.StartsWith("a network-related", StringComparison.InvariantCultureIgnoreCase))
                {
                    return LogLevel.Critical;
                }
                return LogLevel.Error;
            };
        });

    }
}