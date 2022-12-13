using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgentWeb.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
[Authorize]
public class OrderController : Controller
{
    public IActionResult ViewOrder()
    {
        return View();
    }
}