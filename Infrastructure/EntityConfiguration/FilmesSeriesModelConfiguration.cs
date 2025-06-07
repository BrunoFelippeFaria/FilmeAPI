using Filmes.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Filmes.Infrastructure.EntityConfiguration;

public class FilmesSeriesModelConfiguration : IEntityTypeConfiguration<FilmeSeriesModel>
{
    public void Configure(EntityTypeBuilder<FilmeSeriesModel> builder)
    {
        builder.ToTable("FILMES_SERIES");

        builder.HasKey(x => x.Id)
            .HasName("FS_ID");

        builder.Property(f => f.Id)
            .IsRequired(true)
            .HasColumnName("FS_ID");

        builder.Property(f => f.Titulo)
            .IsRequired(true)
            .HasColumnName("FS_TITULO");

        builder.Property(f => f.Tipo)
            .IsRequired(true)
            .HasColumnName("FS_TIPO");

        builder.Property(f => f.Capa)
            .IsRequired(false)
            .HasColumnName("FS_CAPA");

        builder.Property(f => f.Descricao)
            .IsRequired(false)
            .HasColumnName("FS_DESC");

        builder.Property(f => f.Duracao)
            .IsRequired(false)
            .HasColumnName("FS_DURACAO");

        builder.Property(f => f.DataCadastro)
            .HasDefaultValueSql("DATE(CURRENT_TIMESTAMP)")
            .HasColumnName("SYS_DATCAD");

        builder.Property(f => f.UltimaAlteracao)
            .IsRequired(false)
            .HasColumnName("SYS_ULTALT");

        builder.Property(f => f.SYS_DEL)
            .IsRequired(true)
            .HasColumnName("SYS_DEL");
    }
}