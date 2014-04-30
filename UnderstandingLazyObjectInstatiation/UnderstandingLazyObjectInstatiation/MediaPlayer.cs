using System;
using System.IO;

namespace UnderstandingLazyObjectInstatiation
{
	public class MediaPlayer
	{
		public void Play()
		{		}

		public void Pause ()
		{		}

		public void Stop ()
		{		}

		private AllTracks allSongs = new AllTracks();

		public AllTracks GetAllTracks ()
		{
			return allSongs;
		}





	}
}

