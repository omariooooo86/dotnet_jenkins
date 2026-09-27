using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class Index : ControllerBase
{
    [HttpGet(Name = "hello")]
    public IActionResult Hello()
    {
        return Ok("Hello Jenkins!");
    }
}