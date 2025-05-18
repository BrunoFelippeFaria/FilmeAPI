using Filmes.Application.Auth;
using Filmes.Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Filmes.API.Controllers;

[ApiController]
[Route("/api/auth/")]

public class AuthController(IMediator mediator)  : ControllerBase {
    private readonly IMediator _mediator = mediator;

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequest)
    {
        LoginResponseDto? response = await _mediator.Send(new LoginCommand(loginRequest));

        return response == null
            ? NotFound("usuario ou senha incorretos")
            : Ok(response);
    }

}