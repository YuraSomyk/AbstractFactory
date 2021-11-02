using AbstractFactory.Logger;

namespace AbstractFactory.Pattern.Factory {

    abstract class AbstractFactory {

        protected ILogger _logger;

        public AbstractFactory(ILogger logger) {
            _logger = logger;
        }

        public abstract Water.AbstractWater CreateWater();

        public abstract Bottle.AbstractBottle CreateBottle();

        public abstract Cover.AbstractCover CreateCover();
    }
}