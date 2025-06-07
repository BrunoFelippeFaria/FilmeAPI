namespace Filmes.Domain.Entities;

public class FilmeSeries
{
    public int Id { get; set; }
    public required string Titulo { get; set; }
    public string? Capa { get; set; }
    public string? Descricao { get; set; }
    public int? Tipo { get; set; }
    public int? Duracao { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime? UltimaAlteracao { get; set; }
    public int SYS_DEL { get; set; }
}