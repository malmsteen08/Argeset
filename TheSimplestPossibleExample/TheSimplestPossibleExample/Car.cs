using System;

namespace Application
{

	class Car
	{

		public const int MaxSpeed = 100;
		public int CurrentSpeed { get ; set; }
		public string PetName { get ; set; }
		private bool carIsDead ;
		private Radio theMusicBox = new Radio();

		public Car (){}
			
		public Car (string name, int speed)
		{
			CurrentSpeed = speed;
			PetName = name;
		}

		public void CrankTunes(bool state)
		{
			theMusicBox.TurnOn(state);
		}

		public void Accelerate (int delta)
		{
			if (carIsDead)
				Console.WriteLine ("{0} is out of order...", PetName);
			else {
					CurrentSpeed += delta;
					if(CurrentSpeed > maxSpeed)
					{
						carIsDead = true;
						CurrentSpeed = 0;

					Exception ex = new Exception(string.Format("{0} has overheated!", PetName));
					ex.HelpLink = "http://www.CarsRUs.com";
					throw ex;
					}
					else
						Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
				}

			}

		}

}

