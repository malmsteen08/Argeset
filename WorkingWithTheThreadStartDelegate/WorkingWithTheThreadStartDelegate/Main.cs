using System;

using System.Threading;
using System.Windows.Forms;

namespace WorkingWithTheThreadStartDelegate
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("** The AMazing Thread App **\n");
			Console.Write ("Do you want [1] or [2] threads? ");
			string threadCount = Console.ReadLine ();

			Thread primaryThread = Thread.CurrentThread;
			primaryThread.Name = "Primary";

			Console.WriteLine ("-> {0} is exexuting Main()", Thread.CurrentThread.Name);

			Printer p = new Printer ();

			switch (threadCount) 
			{
			case "2":
				Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
				backgroundThread.Name = "Secondary";
				backgroundThread.Start();
				break;
			
			case "1":
				p.PrintNumbers();
				break;
			default:
				Console.WriteLine("I dont know what you want... you get 1 thread.");
				goto case "1";
			}

			MessageBox.Show("I m busy", "Work on main thread...");
			Console.ReadLine();
		}
	}
}
