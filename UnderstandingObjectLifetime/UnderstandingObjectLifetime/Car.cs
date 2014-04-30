using System;

namespace UnderstandingObjectLifetime
{
	public class Car
	{
		public int CurrentSpeed { get; set;}
		public string PetName { get; set;}

		public Car ()
		{
		}

		public Car (string name, int speed)
		{
			PetName = name;
			CurrentSpeed = speed;
		}

		public override string ToString ()
		{
			return string.Format("{0} is going {1} MPH",PetName, CurrentSpeed);
		}
		
	}
}

