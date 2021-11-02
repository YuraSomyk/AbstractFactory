namespace AbstractFactory.Pattern {

    class Client {

        private Water.AbstractWater water;
        private Bottle.AbstractBottle bottle;

        public Client(Factory.AbstractFactory factory) {
            // Абстрагирование процесса инстанцирования.
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
        }

        public void Run() {
            // Абстрагирование вариантов использования.
            bottle.InteractWater(water);
        }
    }
}