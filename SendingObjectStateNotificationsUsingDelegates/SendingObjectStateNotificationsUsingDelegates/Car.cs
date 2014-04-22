using System;

namespace SendingObjectStateNotificationsUsingDelegates
{
	public class Car
	{
		public int MaxSpeed { get ; set; }//const ile ilk deger atanmak zorunda
		public int CurrentSpeed { get ; set; }
		public string PetName { get ; set; }
		private bool carIsDead ;

		public Car (){ MaxSpeed = 100 ; }

		public Car (string name, int maxSp, int currSp)
		{
			CurrentSpeed = currSp;
			MaxSpeed = maxSp;
			PetName = name;
		}
		//Define a delegate type
		public delegate void CarEngineHandler(string msgForCaller);

		//define a member variable of this delegate
		private CarEngineHandler listOfHandlers;

		public void RegisterWithCarEngine (CarEngineHandler methodToCall)
		{
			listOfHandlers = methodToCall;
		}

		public void Accelerate (int delta)
		{
			if (carIsDead) {
				if(listOfHandlers != null)
					listOfHandlers("Sorry, this car is dead");
			}
			else{
				CurrentSpeed += delta;

				//is this car "almost dead"
				if(10 ==(MaxSpeed - CurrentSpeed)&& listOfHandlers != null)
				{
					listOfHandlers("Careful!!");
				}

				if(CurrentSpeed >= MaxSpeed)
					carIsDead = true;
				else
					Console.WriteLine("Current Speed = {0}", CurrentSpeed);
			}
		}
	}
}
