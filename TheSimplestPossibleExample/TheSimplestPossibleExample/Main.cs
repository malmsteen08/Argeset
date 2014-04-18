using System;

namespace TheSimplestPossibleExample
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Console.WriteLine ("Simple Exception Example");
			Console.WriteLine("=> Creating a car and sterring on it!");
			Car myCar = new Car("Zippy",20);
			myCar.CrunkTunes(true);

			try{
				for(int i = 0; i < 10; i++)
					myCar.Accelerate(10);
			}

			catch(Exception e)
			{
				Console.WriteLine("\n***Error!***");
				Console.WriteLine("Method : {0}",e.TargetSite);
				Console.WriteLine("Class defining member : {0}", e.TargetSite.DeclaringType);
				Console.WriteLine("Member Type : {0}", e.TargetSite.MemberType);
				Console.WriteLine("Message : {0}",e.Message);
				Console.WriteLine("Source : {0}", e.Source);
				Console.WriteLine("Stack : {0}", e.StackTrace);
				Console.WriteLine("Help Link : {0}", e.HelpLink);
			}
				Console.WriteLine("\n***Out Of exception logic***");
				Console.ReadLine();
			}

	}
}
