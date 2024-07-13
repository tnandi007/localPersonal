using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace CustomAuthentication.Authentication
{
    public class SampleAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly ClaimsPrincipal _id;

        public SampleAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, "Test"),
            //new Claim("FullName", user.FullName),
            new Claim(ClaimTypes.Role, "Test"),
        };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);
            _id = new ClaimsPrincipal(claimsIdentity);//(new ClaimsIdentity("Api"));
        }

        //protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        //{
        //    throw new NotImplementedException();
        //}

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            //  HttpContext.SignInAsync(
            //CookieAuthenticationDefaults.AuthenticationScheme,
            //new ClaimsPrincipal(claimsIdentity),
            //authProperties);
            return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(_id, "Api")));
        }
    }

    public class SampleSignInHandler : SignInAuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly ClaimsPrincipal _id;

        public SampleSignInHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, "Test"),
            //new Claim("FullName", user.FullName),
            new Claim(ClaimTypes.Role, "Test"),
        };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);
            _id = new ClaimsPrincipal(claimsIdentity);//(new ClaimsIdentity("Api"));
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(_id, "Api")));
        }

        //protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        //{
        //    throw new NotImplementedException();
        //}



        protected override Task HandleSignInAsync(ClaimsPrincipal user, AuthenticationProperties? properties)
        {
            throw new NotImplementedException();
        }

        protected override Task HandleSignOutAsync(AuthenticationProperties? properties)
        {
            throw new NotImplementedException();
        }
    }

    //public class ForceAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>, IAuthorizationHandler
    //{
    //    public ForceAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
    //        : base(options, logger, encoder, clock)
    //    {
    //    }

    //    public Task HandleAsync(AuthorizationHandlerContext context)
    //    {
    //        //throw new NotImplementedException();
    //        return Task.CompletedTask;
    //    }

    //    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    //    {
    //        // Simulate successful authentication by creating claims and a principal
    //        var claims = new List<Claim>
    //    {
    //        new Claim(ClaimTypes.Name, "username"), // Replace with actual username
    //        // Add more claims if needed
    //    };

    //        var claimsIdentity = new ClaimsIdentity(claims, Scheme.Name);
    //        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

    //        var authenticationTicket = new AuthenticationTicket(claimsPrincipal, Scheme.Name);

    //        return AuthenticateResult.Success(authenticationTicket);
    //    }
    //}

}
