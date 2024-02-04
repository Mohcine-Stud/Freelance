using MediatR;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Freelance.Application.Services.Authentication;
using Freelance.Application.Services.Condidate.CandidatService;
using Freelance.Application.Common.Mapping;
using Freelance.Application.Services.Condidate.CompetenceOffreService;

namespace Freelance.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);

        services.AddAutoMapper(typeof(MappingProfile));

        services.AddScoped<IMapper, Mapper>();

        services.AddScoped<IAuthenticationService, AuthenticationService>();

        //services

        services.AddScoped<ICandidateService, CandidatService>();

        services.AddScoped<ICompetenceOffreSevice, CompetenceOffreService>();


        return services;
    }
}
