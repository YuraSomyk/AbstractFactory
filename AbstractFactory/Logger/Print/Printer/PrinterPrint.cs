namespace AbstractFactory.Logger.Print.Printer {

    public class PrinterPrint : IPrint {

        public void Print(string message) {
            System.Console.WriteLine("__Printer__ " + message);
        }
    }
}