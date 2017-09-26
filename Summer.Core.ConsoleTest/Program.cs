using Spring.Context.Support;
using System;
using System.Configuration;

namespace Summer.Core.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new XmlApplicationContext(@".\AppContext.xml");
            var element = context.GetObject<EntityToTest>("teste");
            if (element.Name == "Luiz Carlos Faria")
                Console.WriteLine("Sucesso! ");
            else
                Console.WriteLine("Falha!");

            Console.WriteLine($"OSVersion: {System.Environment.OSVersion}");
            Console.WriteLine($"Platform: {System.Environment.OSVersion.Platform}");
            Console.WriteLine($"Version: {System.Environment.OSVersion.VersionString}");

        }
    }
}
