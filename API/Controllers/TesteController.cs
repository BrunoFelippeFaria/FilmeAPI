using Microsoft.AspNetCore.Mvc;

[Route("/api/teste")]
[ApiController]
public class TesteContoller : ControllerBase {
    [HttpGet]
    public IActionResult Teste () {
        return Ok("hello world");
    }
}