using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ZLogger.Providers
{
	
	public class ZLoggerUnityLoggerProvider : ILoggerProvider, IDisposable
	{
		private UnityDebugLogProcessor debugLogProcessor;

		public ZLoggerUnityLoggerProvider(IOptions<ZLoggerOptions> options)
		{
		}

		public ILogger CreateLogger(string categoryName)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
