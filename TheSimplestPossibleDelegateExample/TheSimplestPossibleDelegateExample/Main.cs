using System;

namespace TheSimplestPossibleDelegateExample
{

	public delegate int BinaryOp(int x, int y);

	public class SimpleMath
	{

		public static int Add (int x, int y)
		{
			return x + y;
		}

		public static int Substract (int x, int y)
		{
			return x - y;
		}

	}


	class MainClass
	{
		static void DisplayDelegateInfo(Delegate delObj)
		{
			foreach(Delegate d in delObj.GetInvocationList())
			{
				Console.WriteLine("Method Type : {0}", d.Method);
				Console.WriteLine("Method Type : {0}", d.Target);
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("**Simple Delegate Example**\n");

			BinaryOp binary = new BinaryOp(SimpleMath.Add);// create BinaryOp delegate obj 'points to' SimpleMath.Add
			DisplayDelegateInfo(binary);
			//invoke Add()
			Console.WriteLine("10 + 10 = {0}", BinaryOp(10, 10));
			Console.ReadLine();
		}

	}
}