using System;

using System.Threading;

namespace ObtainingStaticsAboutTheCurrentThreadOfExe
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("** Primary Thread Stats **\n");

			Thread primaryThread = Thread.CurrentThread;
			primaryThread.Name = "ThePrimaryThread";

			Console.WriteLine("Name of current AppDomain : {0}", Thread.GetDomain().FriendlyName);
			Console.WriteLine("ID of current Context : {0}", Thread.CurrentContext.ContextID);

			Console.WriteLine("Thread Name : {0}", primaryThread.Name);
			Console.WriteLine("Has thread started? : {0}", primaryThread.IsAlive);
			Console.WriteLine("Priority level : {0}", primaryThread.Priority);
			Console.WriteLine("Thread State : {0}", primaryThread.ThreadState);
			Console.ReadLine();
		}
	}
}
