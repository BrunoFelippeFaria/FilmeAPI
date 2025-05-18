using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Filmes.Application.Dtos;
using Filmes.Application.Interfaces;
using Filmes.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;

namespace Filmes.Infrastructure.Services;

public class TokenService : ITokenService
{
    private SymmetricSecurityKey _key = new (Encoding.UTF8.GetBytes("WJEt?c28=8m:"));

    public string GerarToken(Usuarios usuarioDto)
    {
        var claims = new List<Claim>
        {
            new ("UserId", usuarioDto.Id.ToString())
        };

        var credenciais = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new JwtSecurityToken(
            issuer: "BrunoFelippe",
            audience: "FilmesAPI",
            claims: claims,
            expires: DateTime.Now.AddDays(7),
            signingCredentials: credenciais
        );

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.WriteToken(tokenDescriptor);

        return token;
    }
}