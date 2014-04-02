using System;

namespace UnderstandingTheStructureType
{

	class MainClass
	{

		struct Point
		{
			//fields structure
			public int x;
			public int y;

			public void Increment ()
			{
				x++; 
				y++;
			}

			public void Decrement ()
			{
				x--;
				y--;
			}

			public void Display ()
			{
				Console.WriteLine("Y = {0}, Y = {1}", x, y);
			}

		}

		public static void Main (string[] args)
		{
			Console.WriteLine("Structures\n");

			Point myPoint;
			myPoint.x = 324;
			myPoint.y = 63;
			myPoint.Display();

			myPoint.Increment();
			myPoint.Display();
			myPoint.Decrement();
			myPoint.Display();

			Console.ReadLine();
		}

	}

}
