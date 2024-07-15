using System;

namespace Cysharp.Text
{
	internal static class FastNumberWriter
	{
		public static bool TryWriteInt64(Span<char> buffer, out int charsWritten, long value)
		{
			charsWritten = default(int);
			return false;
		}

		public static bool TryWriteUInt64(Span<char> buffer, out int charsWritten, ulong value)
		{
			charsWritten = default(int);
			return false;
		}
	}
}
