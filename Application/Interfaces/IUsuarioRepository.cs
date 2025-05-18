namespace Filmes.Application.Interfaces;

using Filmes.Domain.Entities;

public interface IUsuarioRepository {
    public Task<IEnumerable<Usuarios>> ConsultaUsuarios ();
}