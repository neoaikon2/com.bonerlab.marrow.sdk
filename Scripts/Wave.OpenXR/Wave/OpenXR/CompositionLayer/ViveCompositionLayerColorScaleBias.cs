using System.Runtime.InteropServices;
using UnityEngine.XR.OpenXR.Features;

namespace Wave.OpenXR.CompositionLayer
{
	public class ViveCompositionLayerColorScaleBias : OpenXRFeature
	{
		private const string LOG_TAG = "Wave.OpenXR.ViveCompositionLayer.ColorScaleBias";

		public const string featureId = "vive.wave.openxr.feature.compositionlayer.colorscalebias";

		private const string kOpenXRColorScaleBiasExtensionString = "XR_KHR_composition_layer_color_scale_bias";

		private bool m_ColorScaleBiasExtensionEnabled;

		private const string ExtLib = "waveopenxr";

		public bool ColorScaleBiasExtensionEnabled => false;

		private static void DEBUG(string msg)
		{
		}

		private static void WARNING(string msg)
		{
		}

		private static void ERROR(string msg)
		{
		}

		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		[PreserveSig]
		public static extern void WaveOpenXR_Submit_CompositionLayerColorBias(XrCompositionLayerColorScaleBiasKHR colorBias, int layerID);

		public void Submit_CompositionLayerColorBias(XrCompositionLayerColorScaleBiasKHR colorBias, int layerID)
		{
		}
	}
}
