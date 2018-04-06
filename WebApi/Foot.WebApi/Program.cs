using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.Extensions.Configuration;

namespace Foot.WebApi
{
    public class Program
    {
        public static string urls { get; set; }
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
           .AddEnvironmentVariables()
           .AddCommandLine(args)
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("hosting.json")
           .Build();
            urls = config["server.urls"];
            BuildWebHost(args).Run();
        }
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseKestrel()
                .UseUrls(urls)
                .Build();
    }
}
