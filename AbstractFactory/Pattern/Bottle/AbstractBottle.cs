namespace AbstractFactory.Pattern.Bottle {

    abstract class AbstractBottle {

        public abstract void InteractWater(Water.AbstractWater water);
        
        public abstract void InteractCover(Cover.AbstractCover cover);
    }
}