using AbstractFactory.Logger;

namespace AbstractFactory.Pattern.Bottle {

    class CocaColaBottle: AbstractBottle {

        private ILogger _logger;

        public CocaColaBottle(ILogger logger) {
            _logger = logger;
        }

        public override void InteractWater(Water.AbstractWater water) {
            _logger.Print(this + " interacts with " + water);
        }

        public override void InteractCover(Cover.AbstractCover cover) {
            _logger.Print(this + " interacts with " + cover);
        }
    }
}