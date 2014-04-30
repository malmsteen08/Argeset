using System;

namespace UnderstandingLazyObjectInstatiation
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("** Fun With Lazy Instantiation **\n");

			MediaPlayer myPlayer = new MediaPlayer();
			myPlayer.Play();

			MediaPlayer yourPlayer = new MediaPlayer();
			AllTracks yourMusic = yourPlayer.GetAllTracks();

			Console.ReadLine();
		}
	}
}
