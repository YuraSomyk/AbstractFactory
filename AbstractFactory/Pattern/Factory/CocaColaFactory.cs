﻿namespace AbstractFactory.Pattern.Factory {

    class CocaColaFactory : AbstractFactory {

        public override Water.AbstractWater CreateWater()  {
            return new Water.CocaColaWater();
        }

        public override Bottle.AbstractBottle CreateBottle() {
            return new Bottle.CocaColaBottle();
        }

        public override Cover.AbstractCover CreateCover() {
            return new Cover.CocaColaCover();
        }
    }
}