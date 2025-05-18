namespace Filmes.Application.Dtos;

public class LoginRequestDto
{
    public required string Usuario { get; set; }
    public required string Senha { get; set; }
}