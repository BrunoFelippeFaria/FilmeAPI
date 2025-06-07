
using Filmes.Application.Filmes_Series;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/filmes-series")]
public class FilmesController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> ConsultaFilmeSeries()
    {
        var filmeSeries = await _mediator.Send(new ConsultaFilmesSeriesQuery());

        return filmeSeries == null
            ? NotFound()
            : Ok(filmeSeries);
    }
}