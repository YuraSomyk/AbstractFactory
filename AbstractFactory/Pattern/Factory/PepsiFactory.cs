using AbstractFactory.Logger;

namespace AbstractFactory.Pattern.Factory {

    class PepsiFactory: AbstractFactory {

        private ILogger _logger;

        public PepsiFactory(ILogger logger) : base(logger) {
            logger = _logger;
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