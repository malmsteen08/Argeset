using System;

namespace Application
{
	class Radio
	{
		public void TurnOn(bool on)
		{
			{
			if(on)
				Console.WriteLine("Jamming...");
			else
				Console.WriteLine("Quiet Time ...");
			}
		}
	}
}
