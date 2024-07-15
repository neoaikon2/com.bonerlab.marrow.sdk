using System;

namespace Wave.OpenXR.CompositionLayer
{
	public struct XrCompositionLayerQuad
	{
		public XrStructureType type;

		public IntPtr next;

		public XrCompositionLayerFlags layerFlags;

		public XrSpace space;

		public XrEyeVisibility eyeVisibility;

		public XrSwapchainSubImage subImage;

		public XrPosef pose;

		public XrExtent2Df size;
	}
}
