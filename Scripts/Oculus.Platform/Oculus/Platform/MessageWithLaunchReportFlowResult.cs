using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLaunchReportFlowResult : Message<LaunchReportFlowResult>
	{
		public MessageWithLaunchReportFlowResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override LaunchReportFlowResult GetLaunchReportFlowResult()
		{
			return null;
		}

		protected override LaunchReportFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
