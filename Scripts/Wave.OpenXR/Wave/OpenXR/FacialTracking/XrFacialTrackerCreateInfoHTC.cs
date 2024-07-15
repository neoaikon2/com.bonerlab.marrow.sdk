using System;

namespace Wave.OpenXR.FacialTracking
{
	public struct XrFacialTrackerCreateInfoHTC
	{
		private XrStructureType type;

		private IntPtr next;

		private XrFacialTrackingTypeHTC facialTrackingType;

		public XrFacialTrackerCreateInfoHTC(XrStructureType in_type, IntPtr in_next, XrFacialTrackingTypeHTC in_facialTrackingType)
		{
			type = default(XrStructureType);
			next = (IntPtr)0;
			facialTrackingType = default(XrFacialTrackingTypeHTC);
		}
	}
}
