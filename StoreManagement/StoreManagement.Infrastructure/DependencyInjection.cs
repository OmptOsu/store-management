﻿using Microsoft.Extensions.DependencyInjection;
using StoreManagement.Application.Common.Interfaces.Authentication;
using StoreManagement.Application.Common.Interfaces.Services;
using StoreManagement.Infrastructure.Authentication;
using StoreManagement.Infrastructure.Services;

namespace StoreManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure( this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}
