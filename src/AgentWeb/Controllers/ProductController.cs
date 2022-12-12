using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgentWeb.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
[Authorize]
public class ProductController : Controller 
{
    public IActionResult ViewProduct()
    {
        return View();
    }
   
}