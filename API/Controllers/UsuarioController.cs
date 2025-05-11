using Filmes.Application.Usuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Filmes.API.Controllers;

[Route("/api/usuario")]
[ApiController]

public class UsuarioController(IMediator mediator) : ControllerBase {
    private IMediator _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> ConsultaClientes () {
        var clientes = await _mediator.Send (new UsuarioConsultaQuery());

        return clientes == null
            ? NotFound()
            : Ok(clientes);
    }

}