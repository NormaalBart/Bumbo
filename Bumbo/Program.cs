using System.Globalization;
using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Repositories;
using BumboServices;
using BumboServices.CAO;
using BumboServices.Import;
using BumboServices.Interface;
using BumboServices.Prognoses;
using BumboServices.Roster;
using BumboServices.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Bumbo
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}