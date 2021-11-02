namespace AbstractFactory.Logger.Print.Console {

    public class ConsolePrint: IPrint {

        public void Print(string message) {
            System.Console.WriteLine("__Console__ " + message);
        }
    }
}