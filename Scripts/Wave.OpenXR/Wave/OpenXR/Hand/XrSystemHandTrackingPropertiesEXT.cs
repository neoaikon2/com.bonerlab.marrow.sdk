using System;

namespace Wave.OpenXR.Hand
{
	public struct XrSystemHandTrackingPropertiesEXT
	{
		public XrStructureType type;

		public IntPtr next;

		public XrBool32 supportsHandTracking;
	}
}
