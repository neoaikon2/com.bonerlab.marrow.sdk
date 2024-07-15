using System;
using UnityEngine.XR.OpenXR.Features;

namespace Wave.OpenXR.FacialTracking
{
	public class ViveFacialTracking : OpenXRFeature
	{
		private const string LOG_TAG = "Wave.OpenXR.FacialTracking.ViveFacialTracking";

		public const string kOpenxrExtensionString = "XR_HTC_facial_tracking";

		public const string featureId = "vive.wave.openxr.feature.facial.tracking";

		private bool m_XrInstanceCreated;

		private XrInstance m_XrInstance;

		private XrSystemId m_XrSystemId;

		private bool m_XrSessionCreated;

		private XrSession m_XrSession;

		private bool hasEyeTracker;

		private bool hasLipTracker;

		private XrFacialTrackerHTC m_EyeTracker;

		private XrFacialTrackerHTC m_LipTracker;

		private OpenXRHelper.xrGetInstanceProcAddrDelegate XrGetInstanceProcAddr;

		private OpenXRHelper.xrGetSystemPropertiesDelegate xrGetSystemProperties;

		private OpenXRHelper.xrDestroySpaceDelegate xrDestroySpace;

		private ViveFacialTrackingHelper.xrCreateFacialTrackerHTCDelegate xrCreateFacialTrackerHTC;

		private ViveFacialTrackingHelper.xrDestroyFacialTrackerHTCDelegate xrDestroyFacialTrackerHTC;

		private ViveFacialTrackingHelper.xrGetFacialExpressionsHTCDelegate xrGetFacialExpressionsHTC;

		private XrSystemFacialTrackingPropertiesHTC facialTrackingSystemProperties;

		private XrSystemProperties systemProperties;

		private int eyeUpdateFrame;

		private int lipUpdateFrame;

		private float[] s_EyeExpressionData;

		private float[] s_LipExpressionData;

		private XrFacialExpressionsHTC facialExpressions;

		private void DEBUG(string msg)
		{
		}

		private void WARNING(string msg)
		{
		}

		private void ERROR(string msg)
		{
		}

		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		protected override void OnInstanceDestroy(ulong xrInstance)
		{
		}

		protected override void OnSystemChange(ulong xrSystem)
		{
		}

		protected override void OnSessionCreate(ulong xrSession)
		{
		}

		protected override void OnSessionDestroy(ulong xrSession)
		{
		}

		private XrResult GetSystemProperties(ref XrSystemProperties properties)
		{
			return default(XrResult);
		}

		private XrResult DestroySpace(XrSpace space)
		{
			return default(XrResult);
		}

		private XrResult CreateFacialTrackerHTC(ref XrFacialTrackerCreateInfoHTC createInfo, out XrFacialTrackerHTC facialTracker)
		{
			facialTracker = default(XrFacialTrackerHTC);
			return default(XrResult);
		}

		private XrResult DestroyFacialTrackerHTC(XrFacialTrackerHTC facialTracker)
		{
			return default(XrResult);
		}

		private XrResult GetFacialExpressionsHTC(XrFacialTrackerHTC facialTracker, ref XrFacialExpressionsHTC facialExpressions)
		{
			return default(XrResult);
		}

		private bool GetXrFunctionDelegates(XrInstance xrInstance)
		{
			return false;
		}

		private bool IsFacialTrackingSupported(XrFacialTrackingTypeHTC facialTrackingType)
		{
			return false;
		}

		[Obsolete("This function is deprecated. Please use \"bool CreateFacialTracker(XrFacialTrackingTypeHTC facialTrackingType)\" instead.")]
		public bool CreateFacialTracker(XrFacialTrackingTypeHTC facialTrackingType, out XrFacialTrackerHTC facialTracker)
		{
			facialTracker = default(XrFacialTrackerHTC);
			return false;
		}

		public bool CreateFacialTracker(XrFacialTrackingTypeHTC facialTrackingType)
		{
			return false;
		}

		public bool DestroyFacialTracker(XrFacialTrackingTypeHTC facialTrackingType)
		{
			return false;
		}

		public bool GetFacialExpressions(XrFacialTrackingTypeHTC facialTrackingType, out float[] expressionWeightings)
		{
			expressionWeightings = null;
			return false;
		}
	}
}
