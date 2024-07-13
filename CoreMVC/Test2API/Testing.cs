using Microsoft.AspNetCore.Mvc;
using CommonBase;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.DependencyInjection;
//Microsoft.Extensions.Configuration
//using Microsoft.Extensions.Configuration.Binder;
//using Microsoft.Extensions.Configuration.EnvironmentVariables;
//using Microsoft.Extensions.Configuration.FileExtensions;
//using Microsoft.Extensions.Configuration.Json;

namespace Test2API
{
    public class TestingController:CommonControllerBase   
    {
        //private readonly ILogger<TestingController> _logger;
        private readonly IConfiguration _configuration;
        //private readonly IOptions<IConfiguration> _ioption;

        public TestingController( IConfiguration configuration)
        {
            //_logger = logger;
            _configuration = configuration;
        }


        [ActionName("GetMyProfile")]
        public JsonResult GetMyProfile() {
            var configVal = _configuration["appSettings:Test"];
            //var configValue = _configuration.GetChildren;// getGetValue<int>("appSettings:Test");
            //var builder = new ConfigurationBuilder().Add(); //{ }
            //           .SetBasePath(Directory.GetCurrentDirectory())
            //           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //           .AddEnvironmentVariables();
            //IConfigurationRoot configuration = builder.Build();

            //var settings = new AppSettings(configuration, Key);

            // return settings;

            return Json("Hello Worlds from Test2API"); }

        //[validateAjAx]
        //protected override JsonResult Json()
        //{
        //    return Json();
        //}

    }
}