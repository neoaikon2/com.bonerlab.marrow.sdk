using System;

namespace Wave.OpenXR
{
	public struct XrSessionCreateInfo
	{
		public XrStructureType type;

		public IntPtr next;

		public XrSessionCreateFlags createFlags;

		public XrSystemId systemId;
	}
}
