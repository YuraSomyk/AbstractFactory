namespace AbstractFactory.Pattern {

    class Client {

        private Water.AbstractWater water;
        private Bottle.AbstractBottle bottle;
        private Cover.AbstractCover cover;

        public Client(Factory.AbstractFactory factory) {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
        }

        public void Run() {
            bottle.InteractWater(water);
            bottle.InteractCover(cover);
        }
    }
}