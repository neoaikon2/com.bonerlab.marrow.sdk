using System;
using System.Collections.Generic;

namespace Oculus.Platform
{
	public class MessageWithDataStoreUnderPrivateUserDataStore : Message<Dictionary<string, string>>
	{
		public MessageWithDataStoreUnderPrivateUserDataStore(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override Dictionary<string, string> GetDataStore()
		{
			return null;
		}

		protected override Dictionary<string, string> GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
