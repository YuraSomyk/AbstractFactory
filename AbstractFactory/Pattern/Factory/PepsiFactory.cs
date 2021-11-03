using AbstractFactory.Logger;

namespace AbstractFactory.Pattern.Factory {

    class PepsiFactory: AbstractFactory {

        public PepsiFactory(ILogger logger) :base(logger) {
            _logger = logger;
        }

        public override Water.AbstractWater CreateWater() {
            return new Water.PepsiWater();
        }

        public override Bottle.AbstractBottle CreateBottle() {
            return new Bottle.PepsiBottle(_logger);
        }

        public override Cover.AbstractCover CreateCover() {
            return new Cover.PepsiCover();
        }
    }
}