using AutoMapper;
using Filmes.Domain.Entities;
using Filmes.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Filmes.Infrastructure.Repository;

public class UsuarioRepository (AppDataContext context, IMapper mapper) : IUsuarioRepository {
    private AppDataContext _context = context;
    private IMapper _mapper = mapper;

    public async Task<IEnumerable<Usuarios>> ConsultaUsuarios () {
        var models = await _context.Usuarios
        .Where(u => u.SYS_DEL == 0)
        .ToArrayAsync();  

        return _mapper.Map<IEnumerable<Usuarios>>(models);  
    }

}