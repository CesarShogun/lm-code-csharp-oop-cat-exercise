using System;

namespace OopCatExercise
{
    public class LionCat : Cat
    {
        public LionCat()
        {
            Setting = "wild";
            AverageHeight = 1100;
        }

        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
}
