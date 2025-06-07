using AutoMapper;
using Filmes.Application.Dtos;
using Filmes.Application.Interfaces;
using MediatR;

namespace Filmes.Application.Filmes_Series;

public class ConsultaFilmesSeriesQueryHandler(IFilmesSeriesRepository repo, IMapper mapper) : IRequestHandler<ConsultaFilmesSeriesQuery, IEnumerable<FilmeSeriesDto>>
{
    private readonly IFilmesSeriesRepository _repo = repo;
    private readonly IMapper _mapper = mapper;

    public async Task<IEnumerable<FilmeSeriesDto>> Handle(ConsultaFilmesSeriesQuery request, CancellationToken cancellationToken)
    {
        var filmeSeries = await _repo.ConsultarFilmesSeries();
        return _mapper.Map<IEnumerable<FilmeSeriesDto>>(filmeSeries);
    }
}