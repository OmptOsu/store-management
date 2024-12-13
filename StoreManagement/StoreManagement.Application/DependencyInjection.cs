﻿using Microsoft.Extensions.DependencyInjection;
using StoreManagement.Application.Services.Authentication;

namespace StoreManagement.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication( this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
