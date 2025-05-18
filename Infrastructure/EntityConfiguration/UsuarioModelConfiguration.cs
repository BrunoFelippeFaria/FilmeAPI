using Filmes.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Filmes.Infrastructure.EntityConfiguration;

public class UsuarioModelConfiguration : IEntityTypeConfiguration<UsuariosModel>
{
    public void Configure(EntityTypeBuilder<UsuariosModel> builder)
    {
        builder.ToTable("USUARIOS");

        builder.HasKey(x => x.Id)
            .HasName("USE_ID");

        builder.Property(x => x.Id)
            .HasColumnName("USE_ID");
        
        builder.Property(x => x.Nome)
            .HasColumnName("USE_NOME")
            .HasMaxLength(150)
            .IsRequired();
        
        builder.Property(x => x.Hash)
            .HasColumnName("USE_HASH");

        builder.Property(x => x.Salt)
            .HasColumnName("USE_SALT");
        
        builder.Property(x => x.DataCadastro)
            .HasColumnName("SYS_DATCAD");
        
        builder.Property(x => x.SYS_DEL)
            .HasColumnName("SYS_DEL");
    }
}