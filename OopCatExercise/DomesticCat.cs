using System;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat()
        {
            Setting = "domestic";
            AverageHeight = 23;
        }

        public override string Eat()
        {
            if (new Random().Next(1, 5) > 1) //Will be dismissive 3/4 of the time
                Console.Out.WriteLine("It will do I suppose");
            return "Purrrrrrr";
        }
    }
}
