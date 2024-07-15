using System;

namespace Wave.OpenXR.Hand
{
	public struct XrHandJointVelocitiesEXT
	{
		public XrStructureType type;

		public IntPtr next;

		private uint jointCount;

		private IntPtr jointVelocities;
	}
}
