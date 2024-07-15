using System;

namespace Wave.OpenXR
{
	public struct XrReferenceSpaceCreateInfo
	{
		public XrStructureType type;

		public IntPtr next;

		public XrReferenceSpaceType referenceSpaceType;

		public XrPosef poseInReferenceSpace;
	}
}
