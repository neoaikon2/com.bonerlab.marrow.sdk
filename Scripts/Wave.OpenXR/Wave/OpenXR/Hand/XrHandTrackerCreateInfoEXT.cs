using System;

namespace Wave.OpenXR.Hand
{
	public struct XrHandTrackerCreateInfoEXT
	{
		public XrStructureType type;

		public IntPtr next;

		public XrHandEXT hand;

		public XrHandJointSetEXT handJointSet;

		public XrHandTrackerCreateInfoEXT(XrStructureType in_type, IntPtr in_next, XrHandEXT in_hand, XrHandJointSetEXT in_handJointSet)
		{
			type = default(XrStructureType);
			next = (IntPtr)0;
			hand = default(XrHandEXT);
			handJointSet = default(XrHandJointSetEXT);
		}
	}
}
