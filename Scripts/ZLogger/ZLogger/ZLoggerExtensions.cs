using System;
using Microsoft.Extensions.Logging;

namespace ZLogger
{
	public static class ZLoggerExtensions
	{
		public static void ZLog<T1>(this ILogger logger, LogLevel logLevel, EventId eventId, Exception? exception, string format, T1 arg1) where T1 : notnull
		{
		}

		public static void ZLogInformation<T1>(this ILogger logger, EventId eventId, string format, T1 arg1) where T1 : notnull
		{
		}

		public static void ZLog<T1, T2>(this ILogger logger, LogLevel logLevel, EventId eventId, Exception? exception, string format, T1 arg1, T2 arg2) where T1 : notnull where T2 : notnull
		{
		}

		public static void ZLogInformation<T1, T2>(this ILogger logger, EventId eventId, string format, T1 arg1, T2 arg2) where T1 : notnull where T2 : notnull
		{
		}

		public static void ZLogInformation(this ILogger logger, EventId eventId, string message)
		{
		}

		public static void ZLogInformation(this ILogger logger, EventId eventId, Exception? exception, string message)
		{
		}

		public static void ZLogWarning(this ILogger logger, EventId eventId, string message)
		{
		}

		public static void ZLogWarning(this ILogger logger, EventId eventId, Exception? exception, string message)
		{
		}

		public static void ZLogError(this ILogger logger, EventId eventId, Exception? exception, string message)
		{
		}
	}
}
