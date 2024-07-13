using CustomAuthentication.Authentication;
using CustomAuthentication.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace CustomAuthentication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //return View();
            return Json("Index Page");
        }

        [HttpGet("customPolicy")]
        //[Authorize(Roles ="Test")]
        [Authorize (AuthenticationSchemes = SampleAuthenticationSchemes.CustomScheme)]
        public string GetWithCustomPolicy()
        {
            return "Hello world from GetWithCustomPolicy";
        }

        [HttpGet("customPolicy1")]
        //[Authorize(Roles ="Test")]
        [Authorize (Roles ="Test")]
        public string GetWithCustomPolicy1()
        {
            return "Hello world from GetWithCustomPolicy1";
        }

        [HttpGet("Login")]
        public async Task<IActionResult> Login()
        {
            string returnUrl = "/";
            ViewData["ReturnUrl"] = "/";

            // Normally Identity handles sign in, but you can do it directly
            if (true)
            {
                var claims = new List<Claim>
                {
                    new Claim("user", "Test"),
                    new Claim("role", "Member")
                };

                await HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity(claims, "Cookies", "user", "role")));

                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/");
                }
            }

            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


       
    }
}