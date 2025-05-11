using Filmes.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Filmes.Crosscutting.Dependencies;

public static class DependencyInjection {
    public static IServiceCollection AddDependencies(this IServiceCollection services) {
        services.AddDbContext<AppDataContext>();
        return services;
    }
}