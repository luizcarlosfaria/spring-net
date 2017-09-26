using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Summer.XUnitTestProject
{
    public class RawApplicationContext
    {
        [Fact]
        public void ApplicationContext()
        {
            var context = new XmlApplicationContext(@"C:\_dev\summer-net\Summer.XUnitTestProject\AppContext.xml");
            Assert.NotNull(context);
            var element = context.GetObject<EntityToTest>("teste");
            Assert.NotNull(element);
            Assert.Equal(element.Name, "Luiz Carlos Faria");
        }
    }
}
