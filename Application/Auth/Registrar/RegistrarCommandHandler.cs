using Filmes.Application.Interfaces;
using Filmes.Domain.Entities;
using MediatR;

namespace Filmes.Application.Auth;

public class RegistrarCommandHandler (IAuthService authService, IUsuarioRepository repo) : IRequestHandler<RegistrarCommand, Unit?>
{
    private readonly IAuthService _authService = authService;
    private readonly IUsuarioRepository _repo = repo;

    public async Task<Unit?> Handle(RegistrarCommand request, CancellationToken cancellationToken)
    {
        var usuarioDto = request.UsuarioDto;

        if (usuarioDto == null || string.IsNullOrWhiteSpace(usuarioDto.Nome)) return null;

        var usuario = new Usuarios
        {
            Nome = usuarioDto.Nome,
            DataCadastro = DateOnly.FromDateTime(DateTime.Today)
        };

        _authService.GerarHash(usuario, usuarioDto.Senha!);

        await _repo.AddAsync(usuario);
        await _repo.SaveAsync();

        return Unit.Value;
    }
}