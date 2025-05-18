using Filmes.Application.Interfaces;
using Filmes.Infrastructure.Data;
using Filmes.Infrastructure.Repository;
using Filmes.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Filmes.Crosscutting.Dependencies;

public static class DependencyInjection {
    public static IServiceCollection AddDependencies(this IServiceCollection services) {
        services.AddDbContext<AppDataContext>();

        //repositorios
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ITokenService, TokenService>();

        //AutoMapper
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        //mediator
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

        return services;
    }
}