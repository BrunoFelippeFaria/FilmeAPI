using Filmes.Application.Dtos;
using MediatR;

namespace Filmes.Application.Usuario;

public record UsuarioConsultaQuery () : IRequest<IEnumerable<UsuariosDto>>;