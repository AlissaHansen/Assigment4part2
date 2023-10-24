using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers;

[Route("api/categories")]
public class CategoriesController : ControllerBase
{
    public string SayHello()
    {
        return "Hello from ASP";
    }
}