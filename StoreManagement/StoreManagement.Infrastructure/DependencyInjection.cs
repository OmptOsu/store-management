using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreManagement.Application.Common.Interfaces.Authentication;
using StoreManagement.Application.Common.Interfaces.Persistence;
using StoreManagement.Application.Common.Interfaces.Services;
using StoreManagement.Infrastructure.Authentication;
using StoreManagement.Infrastructure.Persistence;
using StoreManagement.Infrastructure.Services;

namespace StoreManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {

        services.Configure<JwdSettings>(configuration.GetSection(JwdSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}
