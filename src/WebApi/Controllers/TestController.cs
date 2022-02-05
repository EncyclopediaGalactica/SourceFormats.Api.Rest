namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    [Route("test")]
    public String Test()
    {
        return "Ok";
    }
}
