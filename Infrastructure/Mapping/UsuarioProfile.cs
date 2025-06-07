using AutoMapper;
using Filmes.Domain.Entities;
using Filmes.Infrastructure.Models;

namespace Filmes.Infrastructure.Mapping;

public class UsuarioProfile : Profile {
    public UsuarioProfile () {
        CreateMap<UsuariosModel, Usuarios>().ReverseMap();
    }
}