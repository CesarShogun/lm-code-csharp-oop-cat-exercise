using System;

namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        public CheetahCat()
        {
            Setting = "wild";
            AverageHeight = 1000;
        }

        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}
