using System;

namespace Wave.OpenXR.CompositionLayer
{
	public struct XrCompositionLayerCylinderKHR
	{
		public XrStructureType type;

		public IntPtr next;

		public XrCompositionLayerFlags layerFlags;

		public XrSpace space;

		public XrEyeVisibility eyeVisibility;

		public XrSwapchainSubImage subImage;

		public XrPosef pose;

		public float radius;

		public float centralAngle;

		public float aspectRatio;
	}
}
