using System;

using System.Threading;

namespace ABriefReviewOfTheNetDelegate
{

	public delegate int BinaryOp(int x, int y);

	class MainClass
	{

		public static void Main (string[] args)
		{
			Console.WriteLine ("** Sync Delegate Review **");

			Console.WriteLine ("Main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

			BinaryOp b = new BinaryOp (Add);
			IAsyncResult iftAR = b.BeginInvoke (10, 10, null, null);
//			int answer = b(10, 10);

			while (!iftAR.IsCompleted) 
			{			
				Console.WriteLine("Doing more work in Main()");
				Thread.Sleep(1000);
			}
			int answer = b.EndInvoke(iftAR);
//			Console.WriteLine("Doing more work in main()");
			Console.WriteLine("10 + 10 is {0}", answer);
			Console.ReadLine();
		}

		static int Add(int x, int y)
		{
			Console.WriteLine("Add() invoke on thread {0}", Thread.CurrentThread.ManagedThreadId);

			Thread.Sleep(5000);
			return x + y;
		}

	}
}
