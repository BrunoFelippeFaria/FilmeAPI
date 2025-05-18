using Filmes.Application.Dtos;
using MediatR;

namespace Filmes.Application.Auth;

public record RegistrarCommand (UsuarioRegistrarDto UsuarioDto) : IRequest<Unit?>;