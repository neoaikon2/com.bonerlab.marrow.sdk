using System.Runtime.InteropServices;
using UnityEngine.XR.OpenXR.Features;

namespace Wave.OpenXR.CompositionLayer
{
	public class ViveCompositionLayerCylinder : OpenXRFeature
	{
		private const string LOG_TAG = "Wave.OpenXR.ViveCompositionLayer.Cylinder";

		public const string featureId = "vive.wave.openxr.feature.compositionlayer.cylinder";

		private const string kOpenXRCylinderExtensionString = "XR_KHR_composition_layer_cylinder";

		private bool m_CylinderExtensionEnabled;

		private const string ExtLib = "waveopenxr";

		public bool CylinderExtensionEnabled => false;

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
		public static extern void WaveOpenXR_Submit_CompositionLayerCylinder(XrCompositionLayerCylinderKHR cylinder, LayerType layerType, uint compositionDepth, int layerID);

		public void Submit_CompositionLayerCylinder(XrCompositionLayerCylinderKHR cylinder, LayerType layerType, uint compositionDepth, int layerID)
		{
		}
	}
}
