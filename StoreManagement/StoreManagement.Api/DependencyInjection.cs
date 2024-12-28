using Microsoft.AspNetCore.Mvc.Infrastructure;
using StoreManagement.Api.Common.Errors;
using StoreManagement.Api.Common.Mapping;

namespace StoreManagement.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, StoreManagementProblemDetailsFactory>();

        services.AddMapping();
        return services;
    }
}
