using System;

using System.Threading;

namespace WorkingWithTheThreadStartDelegate
{
	public class Printer
	{

		public void PrintNumbers ()
		{
			Console.WriteLine ("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);

			Console.Write ("YourNumbers : ");
			for (int i = 0; i<10; i++) 
			{
				Random r = new Random();
				Thread.Sleep(1000 * r.Next(5));
				Console.WriteLine("{0} ", i);
			}
			Console.WriteLine();
		}

	}
}