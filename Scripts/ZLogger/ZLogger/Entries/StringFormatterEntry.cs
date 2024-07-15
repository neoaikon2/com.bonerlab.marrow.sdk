using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Text.Json;

namespace ZLogger.Entries
{
	public class StringFormatterEntry<TState> : IZLoggerEntry where TState : notnull
	{
		private static readonly ConcurrentQueue<StringFormatterEntry<TState>> cache;

		private static readonly byte[] newLineBytes;

		private TState state;

		private Exception? exception;

		private Func<TState, Exception?, string> formatter;

		public LogInfo LogInfo { get; private set; }

		public static StringFormatterEntry<TState> Create(LogInfo info, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
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
