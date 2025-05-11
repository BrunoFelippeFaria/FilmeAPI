using AutoMapper;
using Filmes.Application.Dtos;
using Filmes.Domain.Entities;

namespace Filmes.Application.Mapping;

public class UsuarioDtoProfile : Profile {
    public UsuarioDtoProfile () {
        CreateMap<UsuariosDto, Usuarios>();
        CreateMap<Usuarios, UsuariosDto>();

    } 
}