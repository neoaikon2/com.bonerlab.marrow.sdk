using System;
using System.Runtime.CompilerServices;

namespace Cysharp.Text
{
	internal static class FormatParser
	{
		public readonly ref struct ParseResult
		{
			public readonly int Index;

			public readonly ReadOnlySpan<char> FormatString;

			public readonly int LastIndex;

			public readonly int Alignment;

			public ParseResult(int index, ReadOnlySpan<char> formatString, int lastIndex, int alignment)
			{
				Index = 0;
				FormatString = default(ReadOnlySpan<char>);
				LastIndex = 0;
				Alignment = 0;
			}
		}

		[MethodImpl(256)]
		private static bool IsDigit(char c)
		{
			return false;
		}

		[MethodImpl(256)]
		public static ParseResult Parse(string format, int i)
		{
			return default(ParseResult);
		}
	}
}
