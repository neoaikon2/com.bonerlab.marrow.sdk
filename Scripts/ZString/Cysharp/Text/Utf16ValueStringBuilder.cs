using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace Cysharp.Text
{
	public struct Utf16ValueStringBuilder : IDisposable, IBufferWriter<char>
	{
		public delegate bool TryFormat<T>(T value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format);

		public static class FormatterCache<T>
		{
			public static TryFormat<T> TryFormatDelegate;

			static FormatterCache()
			{
			}

			private static bool TryFormatString(T value, Span<char> dest, out int written, ReadOnlySpan<char> format)
			{
				written = default(int);
				return false;
			}

			private static bool TryFormatDefault(T value, Span<char> dest, out int written, ReadOnlySpan<char> format)
			{
				written = default(int);
				return false;
			}
		}

		private static char newLine1;

		private static char newLine2;

		private static bool crlf;

		[ThreadStatic]
		private static char[]? scratchBuffer;

		[ThreadStatic]
		internal static bool scratchBufferUsed;

		private char[]? buffer;

		private int index;

		private bool disposeImmediately;

		public void AppendFormat<T1>(string format, T1 arg1) where T1 : notnull
		{
		}

		public void AppendFormat<T1, T2>(string format, T1 arg1, T2 arg2) where T1 : notnull where T2 : notnull
		{
		}

		public void AppendFormat<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) where T1 : notnull where T2 : notnull where T3 : notnull
		{
		}

		private static object CreateFormatter(Type type)
		{
			return null;
		}

		static Utf16ValueStringBuilder()
		{
		}

		public ArraySegment<char> AsArraySegment()
		{
			return default(ArraySegment<char>);
		}

		[MethodImpl(256)]
		public Utf16ValueStringBuilder(bool disposeImmediately)
		{
			buffer = null;
			index = 0;
			this.disposeImmediately = false;
		}

		[MethodImpl(256)]
		public void Dispose()
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
		public void Append(string value)
		{
		}

		[MethodImpl(256)]
		public void Append(string value, int startIndex, int count)
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

		public Memory<char> GetMemory(int sizeHint)
		{
			return default(Memory<char>);
		}

		public Span<char> GetSpan(int sizeHint)
		{
			return default(Span<char>);
		}

		public void Advance(int count)
		{
		}

		private void ThrowArgumentException(string paramName)
		{
		}

		private static void ThrowFormatException()
		{
		}

		private void AppendFormatInternal<T>(T arg, int width, ReadOnlySpan<char> format, string argName) where T : notnull
		{
		}

		private static void ThrowNestedException()
		{
		}

		private static TryFormat<T?> CreateNullableFormatter<T>() where T : struct
		{
			return null;
		}
	}
}
