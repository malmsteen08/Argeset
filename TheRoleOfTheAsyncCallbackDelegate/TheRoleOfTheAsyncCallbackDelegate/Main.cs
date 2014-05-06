using System;

using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace TheRoleOfTheAsyncCallbackDelegate
{
	public delegate int BinaryOp(int x, int y);

	class MainClass
	{

		private static bool isDone = false;

		public static void Main (string[] args)
		{
			Console.WriteLine ("** AsyncCallbackDelegate Example **");
			Console.WriteLine ("Main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

			BinaryOp b = new BinaryOp (Add);
			IAsyncResult iftAR = b.BeginInvoke (10, 10, new AsyncCallback (AddComplete), 
			                                    "Main() thanks you for adding these numbers.");

			while (!isDone) 
			{
				Thread.Sleep(1000);
				Console.WriteLine("Working...");
			}
			Console.ReadLine();
		}

		static int Add(int x, int y)
		{
			Console.WriteLine("Add() invoked on thread {0}",Thread.CurrentThread.ManagedThreadId);
			Thread.Sleep(5000);
			return x+y;
		}

		static void AddComplete(IAsyncResult itfAR)
		{
			Console.WriteLine("AddComplete() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
			Console.WriteLine("Your Addition is complete");

			AsyncResult ar = (AsyncResult)itfAR;
			BinaryOp b = (BinaryOp)ar.AsyncDelegate;
			Console.WriteLine("10 + 10 is {0}",b.EndInvoke(itfAR));

			string msg = (string)itfAR.AsyncState;
			Console.WriteLine(msg);
			isDone = true;
		}

	}

}
