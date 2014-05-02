using System;

using System.Reflection;

namespace LeveragingTheDynamicKeywordToPassArguments
{
	class MainClass
	{

		private static void AddWithReflection ()
		{
			Assembly asm = Assembly.Load ("MathLibrary"); 

			try {
				//Get metadata For SimpleMath type
				Type math = asm.GetType ("MathLibrary.SimpleMath");

				//create a simplemath onthe fly
				object obj = Activator.CreateInstance (math);

				//get info for add
				MethodInfo mi = math.GetMethod ("Add");

				//Invoke Method (Parameters)
				object[] args = {10, 70};
				Console.WriteLine ("Result is : {0}", mi.Invoke (obj, args));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private static void AddWithDynamic ()
		{
			Assembly asm = Assembly.Load ("MathLibrary");

			try {
				Type math = asm.GetType ("MathLibrary.SimpleMath");

				dynamic obj = Activator.CreateInstance (math);
				Console.WriteLine ("Result is : {0}", obj.Add (10, 70));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			AddWithDynamic();
			AddWithReflection();
		}
	}
}
