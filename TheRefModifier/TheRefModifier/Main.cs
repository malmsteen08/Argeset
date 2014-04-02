using System;

namespace TheRefModifier
{

	class MainClass
	{

		public static void SwapStrings (ref string string1, ref string string2)
		{
			var tempStr = string1;
			string1 = string2;
			string2 = tempStr;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Methods!");

			var str1 = "flip";
			var str2 = "flop";

			Console.WriteLine("Before : {0} {1}", str1, str2);

			SwapStrings(ref str1, ref str2);
			Console.WriteLine("After: {0}, {1}", str1, str2);
			Console.ReadLine();
		
		}

	}

}
