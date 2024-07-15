using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ZLogger.Entries
{
	public struct MessageLogState<TPayload> : IZLoggerState where TPayload : notnull
	{
		public static readonly Func<MessageLogState<TPayload>, LogInfo, IZLoggerEntry> Factory;

		public readonly TPayload Payload;

		public readonly string Message;

		public MessageLogState([AllowNull] TPayload payload, string message)
		{
			Payload = default(TPayload);
			Message = null;
		}

		private static IZLoggerEntry factory(MessageLogState<TPayload> self, LogInfo logInfo)
		{
			return null;
		}

		public IZLoggerEntry CreateLogEntry(LogInfo logInfo)
		{
			return null;
		}
	}
}
