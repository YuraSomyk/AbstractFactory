namespace AbstractFactory.Pattern.Factory {

    class PepsiFactory: AbstractFactory {

        public override Water.AbstractWater CreateWater() {
            return new Water.PepsiWater();
        }

        public override Bottle.AbstractBottle CreateBottle() {
            return new Bottle.PepsiBottle();
        }
    }
}