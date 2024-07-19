using System;
using System.Threading.Tasks;

namespace ZLogger.Providers
{
	public class UnityDebugLogProcessor : IAsyncLogProcessor //, IAsyncDisposable
	{
		private readonly ZLoggerOptions options;

		public UnityDebugLogProcessor(ZLoggerOptions options)
		{
		}

		public ValueTask DisposeAsync()
		{
			return default(ValueTask);
		}

		public void Post(IZLoggerEntry log)
		{
		}
	}
}
