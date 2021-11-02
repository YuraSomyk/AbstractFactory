using System;

namespace AbstractFactory.Pattern.Bottle {

    class PepsiBottle : AbstractBottle {

        public override void InteractWater(Water.AbstractWater water) {
            Console.WriteLine(this + " interacts with " + water);
        }

        public override void InteractCover(Cover.AbstractCover cover) {
            Console.WriteLine(this + " interacts with " + cover);
        }
    }
}