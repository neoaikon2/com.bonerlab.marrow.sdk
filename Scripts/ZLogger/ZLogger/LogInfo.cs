using System;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace ZLogger
{
	public readonly struct LogInfo
	{
		public readonly string CategoryName;

		public readonly DateTimeOffset Timestamp;

		public readonly LogLevel LogLevel;

		public readonly EventId EventId;

		public readonly Exception? Exception;

		private static readonly JsonEncodedText CategoryNameText;

		private static readonly JsonEncodedText TimestampText;

		private static readonly JsonEncodedText LogLevelText;

		private static readonly JsonEncodedText EventIdText;

		private static readonly JsonEncodedText EventIdNameText;

		private static readonly JsonEncodedText ExceptionText;

		private static readonly JsonEncodedText NameText;

		private static readonly JsonEncodedText MessageText;

		private static readonly JsonEncodedText StackTraceText;

		private static readonly JsonEncodedText InnerExceptionText;

		private static readonly JsonEncodedText Trace;

		private static readonly JsonEncodedText Debug;

		private static readonly JsonEncodedText Information;

		private static readonly JsonEncodedText Warning;

		private static readonly JsonEncodedText Error;

		private static readonly JsonEncodedText Critical;

		private static readonly JsonEncodedText None;

		public LogInfo(string categoryName, DateTimeOffset timestamp, LogLevel logLevel, EventId eventId, Exception? exception)
		{
			CategoryName = null;
			Timestamp = default(DateTimeOffset);
			LogLevel = default(LogLevel);
			EventId = default(EventId);
			Exception = null;
		}

		public void WriteToJsonWriter(Utf8JsonWriter writer)
		{
		}

		private static void WriteException(Utf8JsonWriter writer, Exception? ex)
		{
		}

		private static JsonEncodedText LogLevelToEncodedText(LogLevel logLevel)
		{
			return default(JsonEncodedText);
		}
	}
}
