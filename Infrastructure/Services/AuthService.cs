using System.Security.Cryptography;
using AutoMapper;
using Filmes.Application.Dtos;
using Filmes.Application.Interfaces;
using Filmes.Domain.Entities;
using Filmes.Infrastructure.Data;
using Filmes.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Filmes.Infrastructure.Services;

public class AuthService(AppDataContext context, IMapper mapper) : IAuthService
{
    private readonly AppDataContext _context = context;
    private readonly IMapper _mapper = mapper;
    private readonly int Interations = 1000;

    public void GerarHash(Usuarios usuario, string senha)
    {
        var salt = RandomNumberGenerator.GetBytes(16);
        var pbkdf2  = new Rfc2898DeriveBytes(senha, salt, Interations, HashAlgorithmName.SHA256);
        var hash = pbkdf2.GetBytes(32);

        usuario.Hash = Convert.ToBase64String(hash);
        usuario.Salt = Convert.ToBase64String(salt);
    }

    public bool VerificarHash(string senha, string salt, string hash)
    {
        var _salt = Convert.FromBase64String(salt);
        var _hash = Convert.FromBase64String(hash);

        var newHash = new Rfc2898DeriveBytes(senha, _salt, Interations, HashAlgorithmName.SHA256).GetBytes(32);
        return newHash.SequenceEqual(_hash);
    }

    public async Task<Usuarios?> ValidarLogin(LoginRequestDto requestDto)
    {
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Nome == requestDto.Usuario);
        if (usuario == null) return null;

        bool hashValido = VerificarHash(requestDto.Senha, usuario.Salt!, usuario.Hash!);
        if (!hashValido) return null;

        return _mapper.Map<Usuarios>(usuario);
    }
}