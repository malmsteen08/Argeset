using System;

namespace TheParamsModifier
{

	class MainClass
	{

		static double CalculateAvarage (params double[] values)
		{
			Console.WriteLine("You sent me {0} doubles.", values.Length);

			//var sum = 0; var 'not provide'
			double sum = 0;
			if(values.Length == 0)
				return sum;

			for(int i = 0; i<values.Length ; i++)
				sum += values[i];
			return (sum / values.Length);
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Methods!");

			var avarage = CalculateAvarage(4.0, 3.2, 5.7, 64.22, 87.42);
			Console.WriteLine("Avarage of data is : {0}", avarage);

			var data = new[] {4.0, 3.2, 5.7};
			avarage = CalculateAvarage(data);
			Console.WriteLine("Avarage of data is {0}", avarage);

			Console.WriteLine("Avarage of data is : {0}", CalculateAvarage());
			Console.ReadLine();
		}

	}

}
