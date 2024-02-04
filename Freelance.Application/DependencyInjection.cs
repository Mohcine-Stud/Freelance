using MediatR;
using Freelance.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Freelance.Application.Services.Authentication;

namespace Freelance.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);

      

        services.AddScoped<IAuthenticationService, AuthenticationService>();


        return services;
    }
}
