using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPurchaseList : Message<PurchaseList>
	{
		public MessageWithPurchaseList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override PurchaseList GetPurchaseList()
		{
			return null;
		}

		protected override PurchaseList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
