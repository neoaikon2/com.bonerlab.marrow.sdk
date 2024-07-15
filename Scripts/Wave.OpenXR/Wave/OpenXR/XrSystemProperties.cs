using System;

namespace Wave.OpenXR
{
	public struct XrSystemProperties
	{
		public XrStructureType type;

		public IntPtr next;

		public XrSystemId systemId;

		public uint vendorId;

		public char[] systemName;

		public XrSystemGraphicsProperties graphicsProperties;

		public XrSystemTrackingProperties trackingProperties;
	}
}
