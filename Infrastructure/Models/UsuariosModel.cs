namespace Filmes.Infrastructure.Models;

public class UsuariosModel {    
    public int Id {get; set;}
    public required string Nome {get; set;}
    public string? Hash {get; set;}
    public string? Salt { get; set; }
    public DateOnly DataCadastro { get; set; }
    public int SYS_DEL {get; set;}
}