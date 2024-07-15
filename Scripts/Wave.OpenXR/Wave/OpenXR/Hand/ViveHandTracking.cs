using System.Collections.Generic;
using UnityEngine.XR;
using UnityEngine.XR.OpenXR.Features;

namespace Wave.OpenXR.Hand
{
	public class ViveHandTracking : OpenXRFeature
	{
		private const string LOG_TAG = "Wave.OpenXR.Hand.ViveHandTracking";

		public const string kOpenxrExtensionString = "XR_EXT_hand_tracking";

		public const string featureId = "vive.wave.openxr.feature.hand.tracking";

		private bool m_XrInstanceCreated;

		private XrInstance m_XrInstance;

		private XrSystemId m_XrSystemId;

		private bool m_XrSessionCreated;

		private XrSession m_XrSession;

		private bool hasReferenceSpaceLocal;

		private bool hasReferenceSpaceStage;

		private XrSpace m_ReferenceSpaceLocal;

		private XrSpace m_ReferenceSpaceStage;

		private bool hasLeftHandTracker;

		private bool hasRightHandTracker;

		private XrHandTrackerEXT leftHandTracker;

		private XrHandTrackerEXT rightHandTracker;

		private OpenXRHelper.xrGetInstanceProcAddrDelegate XrGetInstanceProcAddr;

		private OpenXRHelper.xrGetSystemPropertiesDelegate xrGetSystemProperties;

		private OpenXRHelper.xrEnumerateReferenceSpacesDelegate xrEnumerateReferenceSpaces;

		private OpenXRHelper.xrCreateReferenceSpaceDelegate xrCreateReferenceSpace;

		private OpenXRHelper.xrDestroySpaceDelegate xrDestroySpace;

		private ViveHandTrackingHelper.xrCreateHandTrackerEXTDelegate xrCreateHandTrackerEXT;

		private ViveHandTrackingHelper.xrDestroyHandTrackerEXTDelegate xrDestroyHandTrackerEXT;

		private ViveHandTrackingHelper.xrLocateHandJointsEXTDelegate xrLocateHandJointsEXT;

		private static List<XRInputSubsystem> s_InputSubsystems;

		private XrSystemHandTrackingPropertiesEXT handTrackingSystemProperties;

		private XrSystemProperties systemProperties;

		private XrHandJointLocationEXT[] jointLocationsL;

		private XrHandJointLocationEXT[] jointLocationsR;

		private XrHandJointLocationsEXT locations;

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

		protected override void OnSystemChange(ulong xrSystem)
		{
		}

		protected override void OnSessionCreate(ulong xrSession)
		{
		}

		protected override void OnSessionDestroy(ulong xrSession)
		{
		}

		public XrResult GetSystemProperties(ref XrSystemProperties properties)
		{
			return default(XrResult);
		}

		public XrResult EnumerateReferenceSpaces(uint spaceCapacityInput, out uint spaceCountOutput, out XrReferenceSpaceType spaces)
		{
			spaceCountOutput = default(uint);
			spaces = default(XrReferenceSpaceType);
			return default(XrResult);
		}

		public XrResult CreateReferenceSpace(ref XrReferenceSpaceCreateInfo createInfo, out XrSpace space)
		{
			space = default(XrSpace);
			return default(XrResult);
		}

		public XrResult DestroySpace(XrSpace space)
		{
			return default(XrResult);
		}

		public XrResult CreateHandTrackerEXT(ref XrHandTrackerCreateInfoEXT createInfo, out XrHandTrackerEXT handTracker)
		{
			handTracker = default(XrHandTrackerEXT);
			return default(XrResult);
		}

		public XrResult DestroyHandTrackerEXT(XrHandTrackerEXT handTracker)
		{
			return default(XrResult);
		}

		public XrResult LocateHandJointsEXT(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT locateInfo, ref XrHandJointLocationsEXT locations)
		{
			return default(XrResult);
		}

		private bool GetXrFunctionDelegates(XrInstance xrInstance)
		{
			return false;
		}

		public TrackingOriginModeFlags GetTrackingOriginMode()
		{
			return default(TrackingOriginModeFlags);
		}

		private bool IsReferenceSpaceTypeSupported(uint spaceCountOutput, XrReferenceSpaceType[] spaces, XrReferenceSpaceType space)
		{
			return false;
		}

		private bool IsHandTrackingSupported()
		{
			return false;
		}

		private bool CreateHandTrackers(bool isLeft, out XrHandTrackerEXT handTracker)
		{
			handTracker = default(XrHandTrackerEXT);
			return false;
		}

		public bool GetJointLocations(bool isLeft, out XrHandJointLocationEXT[] handJointLocation)
		{
			handJointLocation = null;
			return false;
		}
	}
}
