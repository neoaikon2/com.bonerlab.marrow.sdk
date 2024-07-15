using System;
using System.Buffers;
using System.Collections.Generic;

namespace Cysharp.Text
{
	internal static class EnumUtil<T>
	{
		private static readonly Dictionary<T, string> names;

		private static readonly Dictionary<T, byte[]> utf8names;

		static EnumUtil()
		{
		}

		public static bool TryFormatUtf16(T value, Span<char> dest, out int written, ReadOnlySpan<char> _)
		{
			written = default(int);
			return false;
		}

		public static bool TryFormatUtf8(T value, Span<byte> dest, out int written, StandardFormat _)
		{
			written = default(int);
			return false;
		}
	}
}
