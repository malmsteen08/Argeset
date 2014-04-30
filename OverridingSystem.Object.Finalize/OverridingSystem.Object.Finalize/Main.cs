using System;
using System.IO;

namespace OverridingSystem.Object.Finalize
{
	class MainClass
	{

		static void DisposeFileStream ()
		{
			FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);

			fs.Close();
			fs.Dispose();
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("** Fun With Dispose **");
			//MyResourceWrapper rw = new MyResourceWrapper ();

			MyResourceWrapper rw = new MyResourceWrapper();
			rw.Dispose();

			MyResourceWrapper rw2 = new MyResourceWrapper();
							
		}
	}
}
