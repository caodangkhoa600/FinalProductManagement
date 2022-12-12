using Microsoft.AspNetCore.Mvc;

namespace AgentWeb.Controllers;

[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = true)]
public class ProductController : Controller 
{
    public IActionResult ViewProduct()
    {
        return View();
    }
   
}