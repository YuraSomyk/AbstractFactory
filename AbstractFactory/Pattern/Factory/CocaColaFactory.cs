using AbstractFactory.Logger;

namespace AbstractFactory.Pattern.Factory {

    class CocaColaFactory : AbstractFactory {

        public CocaColaFactory(ILogger logger) :base(logger) {
            logger = _logger;
        }

        public override Water.AbstractWater CreateWater()  {
            return new Water.CocaColaWater();
        }

        public override Bottle.AbstractBottle CreateBottle() {
            return new Bottle.CocaColaBottle(_logger);
        }

        public override Cover.AbstractCover CreateCover() {
            return new Cover.CocaColaCover();
        }
    }
}