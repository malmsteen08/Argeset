using System;

namespace SendingObjectStateNotificationsUsingDelegates
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("**Delegates as event aneblers**\n");

			Car car = new Car("SlugBug", 100, 10);
			car.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

			Console.WriteLine("**Speeding Up**");
			for(int i = 0; i < 6; i++)
				car.Accelerate(20);
			Console.ReadLine();
		}

		public static void OnCarEngineEvent(string msg)
		{
			Console.WriteLine("\n** Message From Car Object **");
			Console.WriteLine("=> {0}", msg);
		}
	}
}
