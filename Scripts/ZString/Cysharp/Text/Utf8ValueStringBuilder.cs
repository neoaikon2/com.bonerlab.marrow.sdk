using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cysharp.Text
{
	public struct Utf8ValueStringBuilder : IDisposable, IBufferWriter<byte>
	{
		public delegate bool TryFormat<T>(T value, Span<byte> destination, out int written, StandardFormat format);

		public static class FormatterCache<T>
		{
			public static TryFormat<T> TryFormatDelegate;

			static FormatterCache()
			{
			}

			private static bool TryFormatDefault(T value, Span<byte> dest, out int written, StandardFormat format)
			{
				written = default(int);
				return false;
			}
		}

		private static Encoding UTF8NoBom;

		private static byte newLine1;

		private static byte newLine2;

		private static bool crlf;

		[ThreadStatic]
		private static byte[]? scratchBuffer;

		[ThreadStatic]
		internal static bool scratchBufferUsed;

		private byte[]? buffer;

		private int index;

		private bool disposeImmediately;

		public void AppendFormat<T1>(string format, T1 arg1) where T1 : notnull
		{
		}

		public void AppendFormat<T1, T2>(string format, T1 arg1, T2 arg2) where T1 : notnull where T2 : notnull
		{
		}

		private static object CreateFormatter(Type type)
		{
			return null;
		}

		static Utf8ValueStringBuilder()
		{
		}

		public ReadOnlySpan<byte> AsSpan()
		{
			return default(ReadOnlySpan<byte>);
		}

		[MethodImpl(256)]
		public Utf8ValueStringBuilder(bool disposeImmediately)
		{
			buffer = null;
			index = 0;
			this.disposeImmediately = false;
		}

		[MethodImpl(256)]
		public void Dispose()
		{
		}

		public void TryGrow(int sizeHint)
		{
		}

		public void Grow(int sizeHint)
		{
		}

		[MethodImpl(256)]
		public void Append(char value, int repeatCount)
		{
		}

		[MethodImpl(256)]
		public void Append(string value, int startIndex, int count)
		{
		}

		[MethodImpl(256)]
		public void Append(string value)
		{
		}

		[MethodImpl(256)]
		public void Append(ReadOnlySpan<char> value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public Memory<byte> GetMemory(int sizeHint)
		{
			return default(Memory<byte>);
		}

		public Span<byte> GetSpan(int sizeHint)
		{
			return default(Span<byte>);
		}

		public void Advance(int count)
		{
		}

		private void ThrowArgumentException(string paramName)
		{
		}

		private void ThrowFormatException()
		{
		}

		private static void ThrowNestedException()
		{
		}

		private void AppendFormatInternal<T>(T arg, int width, StandardFormat format, string argName) where T : notnull
		{
		}

		private static TryFormat<T?> CreateNullableFormatter<T>() where T : struct
		{
			return null;
		}
	}
}
