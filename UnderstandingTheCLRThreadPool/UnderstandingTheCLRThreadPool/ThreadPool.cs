using System;

using System.Threading;

namespace UnderstandingTheCLRThreadPool
{
	public static class ThreadPool
	{
		public static bool QueueUserWorkItem(WaitCallback callBack);
		public static bool QueueUserWorkItem(WaitCallback callBack, object state);
	}
}

