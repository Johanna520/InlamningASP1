using InlamningASP1.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//TODOS imorogn fredag :   
// innan jag går vidare...
// Steppa genom koden.
// Kommentera vad som sker
// Läs på om det jag inte kan så bra, ex await och async.
// Se björns klipp från handleningen. 
// försök göra uppgift 5-6 innan söndag!

namespace InlamningASP1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
                  CreateDbIfNotExists(host);
                host.Run();
        }

        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var eventContext = services.GetRequiredService<EventContext>();
                eventContext.Seed();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
