using CustomAuthentication.Authentication;
using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace CustomAuthentication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddControllersWithViews();
            builder.Services.AddControllers();

            builder.Services
           .AddAuthentication(SampleAuthenticationSchemes.CustomScheme)
           .AddScheme<AuthenticationSchemeOptions, SampleAuthenticationHandler>(SampleAuthenticationSchemes.CustomScheme, o => { });

            //builder.Services.AddAuthentication
            //builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    //.AddScheme<AuthenticationSchemeOptions, SampleAuthenticationHandler>(CookieAuthenticationDefaults.AuthenticationScheme, o => { });
            //    .AddCookie();
            //.AddCookie(options =>
            //{
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
            //    options.SlidingExpiration = true;
            //    options.AccessDeniedPath = "/Forbidden/";
            //});


            builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie();

            //builder.Services.AddScoped<IAuthorizationHandler, ForceAuthenticationHandler>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            
            app.UseMiddleware<CustomAuthenticationMiddleware>();

            app.UseRouting();
            
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}