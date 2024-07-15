using System;
using System.Reflection;
using Microsoft.Extensions.Logging;

namespace ZLogger
{
	public class AsyncProcessZLogger : ILogger
	{
		private static class StateTypeDetector<TState>
		{
			public static readonly bool IsInternalFormattedLogValues;

			static StateTypeDetector()
			{
			}
		}

		private static class CreateLogEntry<T>
		{
			public static readonly Func<T, LogInfo, IZLoggerEntry>? factory;

			static CreateLogEntry()
			{
			}

			private static void LogForUnity(FieldInfo? fieldInfo)
			{
			}

			private static void LogForUnity(Exception ex)
			{
			}
		}

		private readonly Func<string, Exception?, string> ReturnStringStateFormatter;

		private readonly string categoryName;

		private readonly IAsyncLogProcessor logProcessor;

		public AsyncProcessZLogger(string categoryName, IAsyncLogProcessor logProcessor)
		{
		}

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
		{
		}

		public bool IsEnabled(LogLevel logLevel)
		{
			throw new NotImplementedException();
		}

		public IDisposable BeginScope<TState>(TState state) where TState : notnull
		{
			throw new NotImplementedException();
		}
	}
}
