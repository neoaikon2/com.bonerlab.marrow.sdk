using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ZLogger
{
	public class AsyncStreamLineMessageWriter : IAsyncLogProcessor
	{
		private readonly Stream stream;

		private readonly Channel<IZLoggerEntry> channel;

		private readonly Task writeLoop;

		private readonly CancellationTokenSource cancellationTokenSource;

		[MethodImpl(256)]
		public void Post(IZLoggerEntry log)
		{
		}
		public ValueTask DisposeAsync()
		{
			return default(ValueTask);
		}
	}
}
