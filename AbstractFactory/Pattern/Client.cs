namespace AbstractFactory.Pattern {

    class Client {

        private Water.AbstractWater water;
        private Bottle.AbstractBottle bottle;
        private Cover.AbstractCover cover;

        public Client(Factory.AbstractFactory factory) {
            // Абстрагирование процесса инстанцирования.
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
        }

        public void Run() {
            // Абстрагирование вариантов использования.
            bottle.InteractWater(water);
            bottle.InteractCover(cover);
        }
    }
}