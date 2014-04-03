using System;

namespace UnderstandingThePolimorphicInterface
{
	class ThreeDCircle : Circle
	{

		public new string PetName { get; set; }

		public void Draw()
		{
			Console.WriteLine("Drawing a 3D Circle");
		}
	
	}
}

