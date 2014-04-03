using System;

namespace UnderstandingThePolimorphicInterface
{
	abstract class Shape
	{
		public Shape (string name = "NoName")
		{
			PetName = name;
		}

		public string PetName { get ; set; }

		public virtual void Draw ()
		{
			Console.WriteLine ("Inside Shape.Draw()");
		}

		public static void Main (string[] args)
		{
			Shape[] shape = {new Hexagon (), new Circle (), new Hexagon ("Mick"), 
				new Circle ("Beth"), new Hexagon ("Linda") };

//			var hexagon = new Hexagon ("Beth");
//			hexagon.Draw ();
//
//			var circle = new Circle ("Cindy");
//			//calls base class implementation!
//			circle.Draw ();

			foreach (Shape s in shape) 
			{
				s.Draw();
			}
			Console.ReadLine ();
		}
	}
}
