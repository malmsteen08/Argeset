using System;

namespace UnderstandingObjectLifetime
{
	class MainClass
	{

		static void MakeACar ()
		{
			Car myCar = new Car();
			myCar = null;
		}

		public enum GCCollectionMode
		{
			Default,
			Forced,
			Optimized,
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("** GC Basic **");

			//return reference
			Car refToMyCar = new Car ("Zippy", 50);

			Console.WriteLine (refToMyCar.ToString ());
			Console.ReadLine ();

			Console.WriteLine ("** Fun with System.GC **");

			Console.WriteLine ("Estimated bytes on heap : {0}", GC.GetTotalMemory (false));

			Console.WriteLine ("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));
			//Car refToMyCar = new Car("Zippy", 100);
			Console.WriteLine (refToMyCar.ToString ());

			Console.WriteLine ("\nGeneration of refToMyCar is {0}", GC.GetGeneration (refToMyCar));

			object[] tonsOfObject = new object[50000];
			for (int i = 0; i < 5000; i++)
				tonsOfObject [i] = new object ();

			Console.WriteLine ("Generation of refToMyCar is : {0}", GC.GetGeneration (refToMyCar));

			//if tonsOfObject is still alive
			if (tonsOfObject [9000] != null) {
				Console.WriteLine("Generation of tonsOfObjects[9000] is : {0}",
				                  GC.GetGeneration(tonsOfObject[9000]));			
			}
			else
				Console.WriteLine("tonsOfObject is no longer alive.");

			//how many times generation has been swept
			Console.WriteLine("\nGen 0 has been swept {0} times", GC.GetGeneration(0));
			Console.WriteLine("\nGen 1 has been swept {0} times", GC.GetGeneration(1));
			Console.WriteLine("\nGen 2 has been swept {0} times", GC.GetGeneration(2));
			Console.ReadLine();

			GC.Collect();
			GC.WaitForPendingFinalizers();

			Console.WriteLine(refToMyCar.ToString());

			Console.WriteLine("Generation of refToMyCar is {0}", GC.GetGeneration(refToMyCar));

			Console.ReadLine();
		}

	}
}
