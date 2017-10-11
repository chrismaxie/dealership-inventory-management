using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DealershipInventoryManagement
{
    public class Program
    {
        // We should add some code to this
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
