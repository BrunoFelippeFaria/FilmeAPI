using AutoMapper;
using Filmes.Application.Dtos;
using Filmes.Application.Interfaces;
using MediatR;

namespace Filmes.Application.Usuario;

public class UsuarioConsultaHandler(IUsuarioRepository repo, IMapper mapper) : IRequestHandler<UsuarioConsultaQuery, IEnumerable<UsuariosDto>>
{
    private readonly IUsuarioRepository _repo = repo;
    private readonly IMapper _mapper = mapper;

    public async Task<IEnumerable<UsuariosDto>> Handle(UsuarioConsultaQuery request, CancellationToken cancellationToken)
    {
        var usuarios = await _repo.ConsultaUsuarios();
        return _mapper.Map<IEnumerable<UsuariosDto>>(usuarios); 
    }
}