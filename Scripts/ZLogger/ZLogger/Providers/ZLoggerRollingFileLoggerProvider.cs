using System;
using Microsoft.Extensions.Logging;

namespace ZLogger.Providers
{
	
	public class ZLoggerRollingFileLoggerProvider : ILoggerProvider, IDisposable
	{
		private AsyncStreamLineMessageWriter streamWriter;

		public ILogger CreateLogger(string categoryName)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
