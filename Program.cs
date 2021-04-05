using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

//The following code generates a generic Host.
namespace dotnet_rpg
{
    public class Program //Host is typically configured, built, and run by code in Program class
    {
        public static void Main(string[] args)//Calls CreateHostBuilder (to create and configure a builder object) & calls Build and Run methods on the builder object.
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args) //CreateDeafultBuilder initializes a new instance of the HostBuilder class with pre-configured defaults.
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); //Startup class is specified by calling the UseStartup() method.
                });
    }
}
//After app's host is built, Startup class is specified.
