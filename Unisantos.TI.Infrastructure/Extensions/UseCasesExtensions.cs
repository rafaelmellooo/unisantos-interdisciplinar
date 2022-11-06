﻿using Microsoft.Extensions.DependencyInjection;
using Unisantos.TI.Core.UseCases.Session;
using Unisantos.TI.Core.UseCases.User;

namespace Unisantos.TI.Infrastructure.Extensions;

public static class UseCasesExtensions
{
    public static void AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<CreateSessionUseCase, CreateSessionUseCase>();

        services.AddScoped<CreateUserUseCase, CreateUserUseCase>();
    }
}