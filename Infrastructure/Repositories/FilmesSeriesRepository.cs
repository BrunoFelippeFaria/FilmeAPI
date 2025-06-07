using AutoMapper;
using Filmes.Application.Interfaces;
using Filmes.Domain.Entities;
using Filmes.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Filmes.Infrastructure.Repository;

public class FilmesSeriesRepository (AppDataContext context, IMapper mapper) : IFilmesSeriesRepository
{
    private readonly AppDataContext _context = context;
    private readonly IMapper _mapper = mapper;

    public async Task<IEnumerable<FilmeSeries>> ConsultarFilmesSeries()
    {
        var filmeSeries = await _context.FilmeSeries
            .Where(fs => fs.SYS_DEL == 0)
            .ToArrayAsync();

        return _mapper.Map<IEnumerable<FilmeSeries>>(filmeSeries);
    }
}
