using Filmes.Application.Dtos;
using MediatR;

namespace Filmes.Application.Auth;

public record LoginCommand(LoginRequestDto RequestDto) : IRequest<LoginResponseDto?>; 