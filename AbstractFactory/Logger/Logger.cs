using AbstractFactory.Logger.Print;

namespace AbstractFactory.Logger {

    public class Logger : ILogger {

        private IPrint _print;

        public Logger(IPrint print) {
            _print = print;
        }

        public void Print(string message) {
            _print.Print(message);
        }
    }
}