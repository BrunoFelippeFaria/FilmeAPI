using Filmes.Application.Dtos;
using Filmes.Domain.Entities;

namespace Filmes.Application.Interfaces;

public interface IAuthService
{
    public Task<Usuarios?> ValidarLogin(LoginRequestDto requestDto);
    public void GerarHash(Usuarios usuario, string senha);
}