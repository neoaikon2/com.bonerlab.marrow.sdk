using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cysharp.Text
{
	public static class ZString
	{
		private static Encoding UTF8NoBom;

		[MethodImpl(256)]
		internal static void AppendChars<TBufferWriter>(ref TBufferWriter sb, ReadOnlySpan<char> chars) where TBufferWriter : IBufferWriter<byte>
		{
		}

		public static Utf8ValueStringBuilder CreateUtf8StringBuilder()
		{
			return default(Utf8ValueStringBuilder);
		}

		public static Utf16ValueStringBuilder CreateStringBuilder(bool notNested)
		{
			return default(Utf16ValueStringBuilder);
		}

		public static Utf8ValueStringBuilder CreateUtf8StringBuilder(bool notNested)
		{
			return default(Utf8ValueStringBuilder);
		}

		[MethodImpl(256)]
		public static string Format<T1>(string format, T1 arg1) where T1 : notnull
		{
			return null;
		}

		[MethodImpl(256)]
		public static string Format<T1, T2>(string format, T1 arg1, T2 arg2) where T1 : notnull where T2 : notnull
		{
			return null;
		}

		public static void Utf8Format<T1>(IBufferWriter<byte> bufferWriter, string format, T1 arg1) where T1 : notnull
		{
		}

		public static void Utf8Format<T1, T2>(IBufferWriter<byte> bufferWriter, string format, T1 arg1, T2 arg2) where T1 : notnull where T2 : notnull
		{
		}
	}
}
