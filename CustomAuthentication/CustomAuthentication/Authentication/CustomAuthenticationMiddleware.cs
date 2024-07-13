using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace CustomAuthentication.Authentication
{
    public class CustomAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomAuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            bool isAuthenticated = context.User.Identity.IsAuthenticated;
            string cookiename = context.Request.Cookies.Keys.FirstOrDefault();
            // Perform your authentication logic here
            if (cookiename is null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "username"), // Replace with actual username
                // Add more claims if needed
            };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    // Set additional properties if necessary
                };

                var authenticationTicket = new AuthenticationTicket(new ClaimsPrincipal(claimsIdentity), authProperties, CookieAuthenticationDefaults.AuthenticationScheme);

                await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, authenticationTicket.Principal, authenticationTicket.Properties);

                //await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
            }

            await _next(context);
        }

        private bool IsUserAuthenticated(HttpContext context)
        {
            // Perform your authentication logic here
            // Return true if authentication is successful, otherwise false
            return context.User.Identity.IsAuthenticated; 
        }
    }
}
