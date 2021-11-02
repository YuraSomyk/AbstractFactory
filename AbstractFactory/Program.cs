using AbstractFactory.Pattern;
using AbstractFactory.Pattern.AbstractFactory;
using System;

namespace AbstractFactory {

    class Program {

        static void Main(string[] args) {

            Client client = null;

            client = new Client(new CocaColaFactory());

            Console.WriteLine("Hello AF!");
        }
    }
}