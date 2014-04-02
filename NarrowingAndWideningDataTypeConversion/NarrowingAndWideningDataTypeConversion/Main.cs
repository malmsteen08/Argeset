using System;

namespace NarrowingAndWideningDataTypeConversion
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Type Conversions..\n");

			var numb1 = 30000;
			var numb2 = 30000;
			//short answer = (short)Add(numb1, numb2);

			Console.WriteLine("{0} + {1} = {2}",numb1, numb2, Add(numb1, numb2));
			NarrowingAttempt();
			ProcessBytes();
			Console.ReadLine ();
		}

		static int Add(int x, int y)
		{
			return x + y;
		}

		static void NarrowingAttempt()
		{
			var myByte = 0;
			var myInt = 200;

			myByte = (byte)myInt;
			Console.WriteLine("Value of myByte {0}", myByte);
		}

		static void ProcessBytes ()
		{
			var b1 = 100;
			var b2 = 250;

			try {
				checked{
				var sum = Add (b1, b2);
				Console.WriteLine ("sum = {0}", sum);
					}
				}

			catch(OverflowException ex) 
			{

				Console.WriteLine(ex.Message);

			}

			}
	}
}
