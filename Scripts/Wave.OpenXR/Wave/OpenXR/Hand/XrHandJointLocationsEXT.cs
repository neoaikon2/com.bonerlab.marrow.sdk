using System;

namespace Wave.OpenXR.Hand
{
	public struct XrHandJointLocationsEXT
	{
		public XrStructureType type;

		public IntPtr next;

		public XrBool32 isActive;

		public uint jointCount;

		public IntPtr jointLocations;

		public XrHandJointLocationsEXT(XrStructureType in_type, IntPtr in_next, XrBool32 in_isActive, uint in_jointCount, IntPtr in_jointLocations)
		{
			type = default(XrStructureType);
			next = (IntPtr)0;
			isActive = default(XrBool32);
			jointCount = 0u;
			jointLocations = (IntPtr)0;
		}
	}
}
