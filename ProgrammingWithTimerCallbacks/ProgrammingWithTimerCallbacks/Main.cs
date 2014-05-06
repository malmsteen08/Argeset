using System;

using System.Threading;

namespace ProgrammingWithTimerCallbacks
{
	class MainClass
	{
		static void PrintTime (object state)
		{
			Console.WriteLine("Time is: {0}, Param is : {1}", DateTime.Now.ToLongTimeString(),
			                  state.ToString());
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("** Working with timer type **");

			//create Delegate for timer type
			TimerCallback timeCB = new TimerCallback(PrintTime);

			//Establish timer setting
			Timer t = new Timer(timeCB, "Hello From Main", 0, 1000);

			Console.WriteLine("Hit key to terminate...");
			Console.ReadLine();				 
		}
	}
}
