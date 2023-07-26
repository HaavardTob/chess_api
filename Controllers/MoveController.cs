using Microsoft.AspNetCore.Mvc;

namespace chess_api.Controllers;

[ApiController]
[Route("[controller]")]
public class MoveController : ControllerBase
{
    private readonly ILogger<MoveController> _logger;

    public MoveController(ILogger<MoveController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "Move")]
    [HttpOptions]
    public Move Post(Fen fen)
    {
        return new Move
        {
            from = "e7",
            to = "e6"
        };
    }
}
