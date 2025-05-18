using Filmes.Application.Dtos;
using Filmes.Domain.Entities;

namespace Filmes.Application.Interfaces;

public interface ITokenService
{
    public string GerarToken(Usuarios usuarioDto);
}