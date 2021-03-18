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
// innan jag g�r vidare...
// Steppa genom koden.
// Kommentera vad som sker
// L�s p� om det jag inte kan s� bra, ex await och async.
// Se bj�rns klipp fr�n handleningen. 
// f�rs�k g�ra uppgift 5-6 innan s�ndag!

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
