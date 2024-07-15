using System;

namespace Wave.OpenXR.CompositionLayer
{
	public struct XrCompositionLayerColorScaleBiasKHR
	{
		public XrStructureType type;

		public IntPtr next;

		public XrColor4f colorScale;

		public XrColor4f colorBias;
	}
}
