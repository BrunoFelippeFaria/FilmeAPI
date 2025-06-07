using Filmes.Application.Dtos;
using MediatR;

namespace Filmes.Application.Filmes_Series;

public record ConsultaFilmesSeriesQuery : IRequest<IEnumerable<FilmeSeriesDto>>;