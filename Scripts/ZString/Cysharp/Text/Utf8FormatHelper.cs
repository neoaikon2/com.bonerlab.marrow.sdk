using System.Buffers;
using System.Runtime.CompilerServices;

namespace Cysharp.Text
{
	internal static class Utf8FormatHelper
	{
		[MethodImpl(256)]
		public static void FormatTo<TBufferWriter, T>(ref TBufferWriter sb, T arg, int width, StandardFormat format, string argName) where TBufferWriter : notnull, IBufferWriter<byte> where T : notnull
		{
		}

		private static void FormatToRightJustify<TBufferWriter, T>(ref TBufferWriter sb, T arg, int width, StandardFormat format, string argName) where TBufferWriter : notnull, IBufferWriter<byte> where T : notnull
		{
		}
	}
}
