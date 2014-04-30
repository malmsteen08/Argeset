using System;

namespace UnderstandingLazyObjectInstatiation
{
	public class AllTracks
	{

		private Song[] allSongs= new Song[10000];
	
		public AllTracks()
		{
			Console.WriteLine("Filling up the songs!");
		}
	}
}

