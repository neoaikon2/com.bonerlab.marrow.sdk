using System;

namespace Wave.OpenXR.FacialTracking
{
	public struct XrSystemFacialTrackingPropertiesHTC
	{
		public XrStructureType type;

		public IntPtr next;

		public XrBool32 supportEyeFacialTracking;

		public XrBool32 supportLipFacialTracking;
	}
}
