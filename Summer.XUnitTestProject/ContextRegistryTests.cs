using System;
using System.Configuration;
using Xunit;

namespace Summer.XUnitTestProject
{
    public class ContextRegistryTests
    {
        [Fact]
        public void GetContextTest()
        {
            var config = ConfigurationManager.OpenExeConfiguration(@"C:\_dev\summer-net\Summer.XUnitTestProject\bin\Debug\netcoreapp2.0\Summer.XUnitTestProject.dll");
            Assert.NotNull(config.GetSection("spring/context"));
            Assert.NotNull(config.GetSection("spring/objects"));

            Spring.Context.Support.ContextRegistry.GetContext(config);
        }
    }
}
