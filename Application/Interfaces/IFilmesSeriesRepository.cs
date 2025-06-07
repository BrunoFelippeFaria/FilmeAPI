using Filmes.Domain.Entities;

namespace Filmes.Application.Interfaces;

public interface IFilmesSeriesRepository
{
    public Task<IEnumerable<FilmeSeries>> ConsultarFilmesSeries();
}