using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPlatformInitialize : Message<PlatformInitialize>
	{
		public MessageWithPlatformInitialize(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override PlatformInitialize GetPlatformInitialize()
		{
			return null;
		}

		protected override PlatformInitialize GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
