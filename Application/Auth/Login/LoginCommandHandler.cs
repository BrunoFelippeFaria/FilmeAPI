using Filmes.Application.Dtos;
using Filmes.Application.Interfaces;
using Filmes.Domain.Entities;
using MediatR;

namespace Filmes.Application.Auth;

public class LoginCommandHandler(IAuthService authService, ITokenService tokenService) : IRequestHandler<LoginCommand, LoginResponseDto?>
{
    private readonly IAuthService _authService = authService;
    private readonly ITokenService _tokenService = tokenService;

    public async Task<LoginResponseDto?> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var loginRequest = request.RequestDto;
        Usuarios? usuario = await _authService.ValidarLogin(loginRequest);

        if (usuario == null) return null;

        var token = _tokenService.GerarToken(usuario);

        LoginResponseDto loginResponse = new()
        {
            Token = token
        };

        return loginResponse;
    }
} 