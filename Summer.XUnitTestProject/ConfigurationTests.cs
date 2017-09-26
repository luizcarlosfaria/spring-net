using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Xunit;

namespace Summer.XUnitTestProject
{

    public class ConfigurationTests
    {

        [Fact]
        public void AppSettingsTest()
        {
            var config = ConfigurationManager.OpenExeConfiguration(@"C:\_dev\summer-net\Summer.XUnitTestProject\bin\Debug\netcoreapp2.0\Summer.XUnitTestProject.dll");
            Assert.Equal("bar", config.AppSettings.Settings["foo"].Value);
        }
    }
}
