using Filmes.Infrastructure.EntityConfiguration;
using Filmes.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Filmes.Infrastructure.Data;

public class AppDataContext : DbContext {
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=../Infrastructure/Data/FILMEDATA.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioModelConfiguration).Assembly);
    }

    public required DbSet<UsuariosModel> Usuarios {get; set;}
}