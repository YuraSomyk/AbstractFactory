using AbstractFactory.DependencyInjection;
using AbstractFactory.DependencyInjection.Logger;
using AbstractFactory.DependencyInjection.Operation.Scoped;
using AbstractFactory.DependencyInjection.Operation.Singleton;
using AbstractFactory.DependencyInjection.Operation.Transient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace AbstractFactory {

    class Program {

        static Task Main(string[] args) {

            using IHost host = CreateHostBuilder(args).Build();

            return host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddTransient<ITransientOperation>()
                            .AddScoped<IScopedOperation, DefaultOperation>()
                            .AddSingleton<ISingletonOperation, DefaultOperation>()
                            .AddTransient<OperationLogger>());

    }
}