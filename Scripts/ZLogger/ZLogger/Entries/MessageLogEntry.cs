using System.Buffers;
using System.Collections.Concurrent;
using System.Text.Json;

namespace ZLogger.Entries
{
	public class MessageLogEntry<TPayload> : IZLoggerEntry where TPayload : notnull
	{
		private static readonly ConcurrentQueue<MessageLogEntry<TPayload>> cache;

		private MessageLogState<TPayload> state;

		public LogInfo LogInfo { get; private set; }

		private MessageLogEntry()
		{
		}

		public static MessageLogEntry<TPayload> Create(in LogInfo logInfo, in MessageLogState<TPayload> state)
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
