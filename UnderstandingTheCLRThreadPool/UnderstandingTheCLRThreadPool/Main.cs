using System;

using System.Threading;

namespace UnderstandingTheCLRThreadPool
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("** Fun With The CLR Thread Pool **\n");

			Console.WriteLine ("Main thread started. ThreadID: {0}", Thread.CurrentThread.ManagedThreadId);

			Printer p = new Printer ();

			WaitCallback workItem = new WaitCallback (PrintTheNumbers);

			for (int i = 0; i < 10; i ++) 
			{
				ThreadPool.QueueUserWorkItem(workItem, p);
			}

			Console.WriteLine("All tasks queued");
			Console.ReadLine();
		}

		static void PrintTheNumbers (object state)
		{
			Printer task = (Printer)state;
			task.PrintNumbers();
		}
	}

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