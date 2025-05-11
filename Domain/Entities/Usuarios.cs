namespace Filmes.Domain.Entities;

public class Usuarios {
    public int Id {get; set;}
    public required string Nome {get; set;}
    public string? Hash {get; set;}
    public DateOnly DataCadastro {get; set;}
    public int SYS_DEL {get; set;}
}