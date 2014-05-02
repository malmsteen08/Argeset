using System;

using System.Collections.Generic;

namespace TheRoleOfTheCSharpDynamicKeyword
{
	class MainClass
	{

		static void PrintThreeStrings ()
		{
			var s1 = "Greetings";
			var s2 = "From";
			var s3 = "Minneapolis";

			Console.WriteLine("s1 is type of : {0}", s1.GetType());
			Console.WriteLine("s2 is type of : {0}",s2.GetType());
			Console.WriteLine("s3 is typeof : {0}", s3.GetType());
		}

		static void ChangeDynamicDataType ()
		{
			//declare data point 't'
			dynamic t = "Hello";
			Console.WriteLine("t is oftype : {0}", t.GetType());

			t = false;
			Console.WriteLine("t is of type : {0}", t.GetType());

			t = new List<int>();
			Console.WriteLine("t is of type : {0}" , t.GetType());
		}

		static void InvokeMembersOnDynamicData ()
		{
			dynamic textData1 = "Hello";
//			Console.WriteLine(textData1.ToUpper());
//
//			Console.WriteLine(textData1.toupper());
//			Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
			try {
				Console.WriteLine (textData1.ToUpper ());
				Console.WriteLine (textData1.toupper ());
				Console.WriteLine (textData1.Foo (10, "ee", DateTime.Now));
			} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex) {
				Console.WriteLine(ex.Message);
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			PrintThreeStrings();
			ChangeDynamicDataType();
			InvokeMembersOnDynamicData();
		}
	}
}
