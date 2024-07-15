using System;
using Microsoft.Extensions.Logging;

namespace ZLogger.Providers
{
	
	public class ZLoggerLogProcessorLoggerProvider : ILoggerProvider, IDisposable
	{
		private IAsyncLogProcessor processor;

		public ILogger CreateLogger(string categoryName)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
