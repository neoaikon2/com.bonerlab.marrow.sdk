using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ZLogger.Entries
{
	public struct FormatLogState<TPayload, T1> : IZLoggerState where TPayload : notnull where T1 : notnull
	{
		public static readonly Func<FormatLogState<TPayload, T1>, LogInfo, IZLoggerEntry> Factory;

		public readonly TPayload Payload;

		public readonly string Format;

		public readonly T1 Arg1;

		public FormatLogState([AllowNull] TPayload payload, string format, T1 arg1)
		{
			Payload = default(TPayload);
			Format = null;
			Arg1 = default(T1);
		}

		private static IZLoggerEntry factory(FormatLogState<TPayload, T1> self, LogInfo logInfo)
		{
			return null;
		}

		public IZLoggerEntry CreateLogEntry(LogInfo logInfo)
		{
			return null;
		}
	}
	public struct FormatLogState<TPayload, T1, T2> : IZLoggerState where TPayload : notnull where T1 : notnull where T2 : notnull
	{
		public static readonly Func<FormatLogState<TPayload, T1, T2>, LogInfo, IZLoggerEntry> Factory;

		public readonly TPayload Payload;

		public readonly string Format;

		public readonly T1 Arg1;

		public readonly T2 Arg2;

		public FormatLogState([AllowNull] TPayload payload, string format, T1 arg1, T2 arg2)
		{
			Payload = default(TPayload);
			Format = null;
			Arg1 = default(T1);
			Arg2 = default(T2);
		}

		private static IZLoggerEntry factory(FormatLogState<TPayload, T1, T2> self, LogInfo logInfo)
		{
			return null;
		}

		public IZLoggerEntry CreateLogEntry(LogInfo logInfo)
		{
			return null;
		}
	}
}
