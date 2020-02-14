using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace DIWithConstructorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<IMyService>(s => new MyService("MyConnectionString"));
            var provider = services.BuildServiceProvider();
            var myService = provider.GetService<IMyService>();

            myService.GetConstructorParameter();
        }
    }
}
