using System;

namespace Wave.OpenXR.FacialTracking
{
	public struct XrFacialExpressionsHTC
	{
		public XrStructureType type;

		public IntPtr next;

		public XrBool32 isActive;

		public XrTime sampleTime;

		public uint expressionCount;

		public IntPtr expressionWeightings;
	}
}
