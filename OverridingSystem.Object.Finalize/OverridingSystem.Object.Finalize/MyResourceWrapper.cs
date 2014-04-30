using System;

namespace OverridingSystem.Object.Finalize
{
	public class MyResourceWrapper : IDisposable
	{
		private bool disposed = false;

		public void Dispose()
		{
			Console.WriteLine("** In Dispose **");

			CleanUp(true);

			GC.SuppressFinalize(this);
		}
		void CleanUp (bool disposing)
		{
			if (!this.disposed) {
			
			}
			disposed =true;
		}


	}
}

