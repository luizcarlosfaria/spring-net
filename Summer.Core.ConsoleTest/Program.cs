﻿using Spring.Context.Support;
using System;
using System.Configuration;

namespace Summer.Core.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new XmlApplicationContext(@".\AppContext.xml");
            var person = context.GetObject<Person>("blablabla");

            Console.WriteLine($"OSVersion: {System.Environment.OSVersion}");
            Console.WriteLine($"MachineName: {System.Environment.MachineName}");
            Console.WriteLine($"Path: {System.Environment.CurrentDirectory}");
        }
    }
}
