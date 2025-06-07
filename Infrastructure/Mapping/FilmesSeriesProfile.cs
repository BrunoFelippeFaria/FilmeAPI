using AutoMapper;
using Filmes.Domain.Entities;
using Filmes.Infrastructure.Models;

namespace Filmes.Infrastructure.Mapping;

public class FilmesSeriesProfile : Profile {
    public FilmesSeriesProfile () {
        CreateMap<FilmeSeriesModel, FilmeSeries>().ReverseMap();
    }
}