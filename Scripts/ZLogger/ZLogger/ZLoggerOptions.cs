using System;
using System.Buffers;
using System.Text.Json;

namespace ZLogger
{
	public class ZLoggerOptions
	{
		[ThreadStatic]
		private static Utf8JsonWriter? jsonWriter;

		private static byte[] newLine;

		public Action<LogInfo, Exception>? InternalErrorLogger { get; set; }

		public TimeSpan? FlushRate { get; set; }

		public Action<IBufferWriter<byte>, LogInfo>? PrefixFormatter { get; set; }

		public Action<IBufferWriter<byte>, LogInfo>? SuffixFormatter { get; set; }

		public Action<IBufferWriter<byte>, Exception> ExceptionFormatter { get; set; }

		public bool EnableStructuredLogging { get; set; }

		public Action<Utf8JsonWriter, LogInfo> StructuredLoggingFormatter { get; set; }

		public JsonEncodedText MessagePropertyName { get; set; }

		public JsonEncodedText PayloadPropertyName { get; set; }

		public JsonSerializerOptions JsonSerializerOptions { get; set; }

		internal Utf8JsonWriter GetThreadStaticUtf8JsonWriter(IBufferWriter<byte> buffer)
		{
			return null;
		}

		private static void DefaultStructuredLoggingFormatter(Utf8JsonWriter writer, LogInfo info)
		{
		}

		private static void DefaultExceptionLoggingFormatter(IBufferWriter<byte> writer, Exception exception)
		{
		}

		private static void WriteExceptionLoggingCore(IBufferWriter<byte> writer, Exception exception)
		{
		}

		private static void Write(IBufferWriter<byte> writer, string message)
		{
		}

		private static void Write(IBufferWriter<byte> writer, string message1, string message2)
		{
		}

		private static void Write(IBufferWriter<byte> writer, string message1, string message2, string message3)
		{
		}
	}
}
