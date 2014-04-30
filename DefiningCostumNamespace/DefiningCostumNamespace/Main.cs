using System;
using MyShapes;
using My3DShapes;
using MyShape = MyShapes.Hexagon;//  A
using bfHome = System.Runtime.Serialization.Formatters.Binary;

namespace DefiningCostumNamespace
{

	class MainClass
	{
		
		public static void Main (string[] args)
		{
			My3DShapes.Hexagon h = new My3DShapes.Hexagon();
			My3DShapes.Square s = new My3DShapes.Square();
			My3DShapes.Circle c = new My3DShapes.Circle();

			MyShape h2 = new MyShape(); //  B   bu şekilde de tanımlanabilir

			bfHome.BinaryFormatter b = new bfHome.BinaryFormatter();
		}

}
