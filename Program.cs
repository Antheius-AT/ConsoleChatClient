using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Challenge
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            var service = host.Services.GetRequiredService<IPostMessageService>();
            var result = await service.PostMessage("https://fhwnnetworkprog.azurewebsites.net/api/Receiver/", "Hallo Christian, sehr sehr spannende Vorlesung!");

            Console.ReadLine();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logger =>
                {
                    logger.ClearProviders();
                    logger.AddConsole();
                })
                .ConfigureServices(services =>
                {
                    services.AddTransient<IPostMessageService, PostMessageService>();
                });
        }

    }
}
