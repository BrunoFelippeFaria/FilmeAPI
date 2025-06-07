using AutoMapper;
using Filmes.Application.Dtos;
using Filmes.Domain.Entities;

namespace Filmes.Application.Mapping;

public class FilmeSeriesDtoProfile : Profile {
    public FilmeSeriesDtoProfile () {
        CreateMap<FilmeSeriesDto, FilmeSeries>().ReverseMap();
    } 
}