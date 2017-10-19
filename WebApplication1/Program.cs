using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NetStandardClassLibraryB;
using NetStandardClassLibraryA;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(ClassLibraryA.LibraryA); // This one is found by both Mac and Windows

            Console.WriteLine(ClassLibraryB.LibraryB); // This one is only found by Windows

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
