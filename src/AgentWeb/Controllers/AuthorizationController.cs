using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AgentWeb.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class AuthorizationController : Controller
{
    public IActionResult Login(string returnUrl = "Product/ViewProduct")
    {
        ViewData["ReturnUrl"] = returnUrl;
        return View();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(string email, string password, string returnUrl)
    {
        if (email == "admin@gmail.com" && password == "123")
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("name", email));
            claims.Add(new Claim(ClaimTypes.Name, email));
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);
            return Redirect(returnUrl);
        }

        return BadRequest();
    }

    public IActionResult Register()
    {
        return View();
    }
}