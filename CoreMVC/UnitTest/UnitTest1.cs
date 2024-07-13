using Microsoft.Extensions.Configuration;
using Test2API;

namespace UnitTest
{
    public class Tests
    {
        private readonly IConfiguration _configuration;
        public Tests()
        {
            //var currentDicrectory = Directory.GetCurrentDirectory()
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@"appsettings.json",false,false)
                //.AddEnvironmentVariables()
                .Build();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var value = _configuration.GetSection("appsettings:Test");
            //TestingController 
            Assert.Pass();
        }
    }
}