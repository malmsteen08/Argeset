using System;

using System.Threading;

namespace ForegroundThreadsAndBackgroundThreads
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Console.WriteLine ("** Background Threads **\n");

			Printer p = new Printer ();
//			Thread bgroundThread = new Thread(new ThreadStart(p.PrintNumbers));

			Thread[] threads = new Thread[10];
			for (int i = 0; i < 10; i++) 
			{
				threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
				threads[i].Name = string.Format ("Worker THread #{0}", i);
			}

			foreach (Thread t in threads)
				t.Start();
			Console.ReadLine();

//			bgroundThread.IsBackground = true;
//			bgroundThread.Start();
		}

		public class Printer
		{
			//lock token
			private object threadLock = new object();

			public void PrintNumbers ()
			{
				lock (threadLock) {
					Console.WriteLine ("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);

					Console.Write ("YourNumbers : ");
					for (int i = 0; i<10; i++) {
						Random r = new Random ();
						Thread.Sleep (1000 * r.Next (5));
						Console.WriteLine ("{0} ", i);
					}
					Console.WriteLine ();
				}
			}
		}
	}
}
