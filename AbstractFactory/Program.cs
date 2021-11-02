using AbstractFactory.Pattern;
using System;

namespace AbstractFactory {

    class Program {

        static void Main(string[] args) {

            Client client = null;

            client = new Client(new Pattern.Factory.CocaColaFactory());
            client.Run();

            client = new Client(new Pattern.Factory.PepsiFactory());
            client.Run();

            Console.ReadKey();
        }
    }
}