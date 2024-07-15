using System;

namespace Wave.OpenXR.Hand
{
	public struct XrHandJointsLocateInfoEXT
	{
		public XrStructureType type;

		public IntPtr next;

		public XrSpace baseSpace;

		public XrTime time;

		public XrHandJointsLocateInfoEXT(XrStructureType in_type, IntPtr in_next, XrSpace in_baseSpace, XrTime in_time)
		{
			type = default(XrStructureType);
			next = (IntPtr)0;
			baseSpace = default(XrSpace);
			time = default(XrTime);
		}
	}
}
