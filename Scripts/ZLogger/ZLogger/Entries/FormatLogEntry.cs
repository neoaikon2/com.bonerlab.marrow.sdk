using System.Buffers;
using System.Collections.Concurrent;
using System.Text.Json;

namespace ZLogger.Entries
{
	public class FormatLogEntry<TPayload, T1> : IZLoggerEntry
	{
		private static readonly ConcurrentQueue<FormatLogEntry<TPayload, T1>> cache;

		private FormatLogState<TPayload, T1> state;

		public LogInfo LogInfo { get; private set; }

		private FormatLogEntry()
		{
		}

		public static FormatLogEntry<TPayload, T1> Create(in LogInfo logInfo, in FormatLogState<TPayload, T1> state)
		{
			return null;
		}

		public void FormatUtf8(IBufferWriter<byte> writer, ZLoggerOptions options, Utf8JsonWriter? jsonWriter)
		{
		}

		public void Return()
		{
		}
	}
	public class FormatLogEntry<TPayload, T1, T2> : IZLoggerEntry
	{
		private static readonly ConcurrentQueue<FormatLogEntry<TPayload, T1, T2>> cache;

		private FormatLogState<TPayload, T1, T2> state;

		public LogInfo LogInfo { get; private set; }

		private FormatLogEntry()
		{
		}

		public static FormatLogEntry<TPayload, T1, T2> Create(in LogInfo logInfo, in FormatLogState<TPayload, T1, T2> state)
		{
			return null;
		}

		public void FormatUtf8(IBufferWriter<byte> writer, ZLoggerOptions options, Utf8JsonWriter? jsonWriter)
		{
		}

		public void Return()
		{
		}
	}
}
