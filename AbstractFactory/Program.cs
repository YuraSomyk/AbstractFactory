using AbstractFactory.Logger;
using AbstractFactory.Logger.Print;
using AbstractFactory.Logger.Print.Printer;
using AbstractFactory.Pattern;
using AbstractFactory.Pattern.Factory;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactory {

    class Program {

        static void Main(string[] args) {

            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<ILogger, Logger.Logger>()
                .AddSingleton<IPrint, PrinterPrint>()
                .BuildServiceProvider();

            Client client = null;

            client = new Client(new CocaColaFactory(serviceProvider.GetService<ILogger>()));
            client.Run();
        }
    }
}