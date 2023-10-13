using System.IO;
using System.Reflection;
using Microsoft.Extensions.Hosting;

namespace MassTransit.WindowsService
{
    public static class Program
    {
        public static void Main(string[] args) => StartMassTransitRunner(args);

        private static void StartMassTransitRunner(string[] args)
        {
            var assemblyPath = Assembly.GetExecutingAssembly().Location;
            Directory.SetCurrentDirectory(Directory.GetParent(assemblyPath)!.FullName);

            var hostBuilder = Host.CreateDefaultBuilder(args);
            hostBuilder = hostBuilder.ConfigureMassTransitConsumers(null, null
                , Assembly.GetExecutingAssembly());
            hostBuilder = hostBuilder.UseWindowsService(); //automatically detects whether in Service or Console...
            //hostBuilder = hostBuilder.UseConsoleLifetime(); ...therefore this is not needed and even toxic for Windows-Service
            var host = hostBuilder.Build();
            host.Run(); //runs all registered IHostedService Classes and waits for their Completion
        }
    }
}