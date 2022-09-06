using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
		public bool IsAsleep { get; private set; }
		public string Setting { get; protected set; }
		public int AverageHeight { get; protected set; }


        public Cat()
		{
			IsAsleep = false;
		}

		public void GoToSleep()
		{
			IsAsleep = true;
		}

		public void WakeUp()
		{
			IsAsleep = false;
		}

		public abstract string Eat();
	}
}
