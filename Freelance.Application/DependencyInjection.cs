using MediatR;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Freelance.Application.Services.Authentication;
using Freelance.Application.Services.Condidate.CandidatService;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.Common.Mapping;

namespace Freelance.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);

        services.AddScoped<IAuthenticationService, AuthenticationService>();

        services.AddScoped<IMapper, Mapper>();

        services.AddScoped<ICandidateService, CandidatService>();

        return services;
    }
}
