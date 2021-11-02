using System;

namespace AbstractFactory.Pattern.Bottle {

    class CocaColaBottle: AbstractBottle {

        public override void InteractWater(Water.AbstractWater water) {
            Console.WriteLine(this + " interacts with " + water);
        }
    }
}