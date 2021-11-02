namespace AbstractFactory.Pattern.Factory {

    abstract class AbstractFactory {

        public abstract Water.AbstractWater CreateWater();

        public abstract Bottle.AbstractBottle CreateBottle();
    }
}