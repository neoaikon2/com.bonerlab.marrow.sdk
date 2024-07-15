using System;

namespace ZLogger
{
	public interface IAsyncLogProcessor
	{
		void Post(IZLoggerEntry log);
	}
}
