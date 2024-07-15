using System;
using System.Runtime.InteropServices;
using UnityEngine.XR.OpenXR.Features;

namespace Wave.OpenXR.CompositionLayer
{
	public class ViveCompositionLayer : OpenXRFeature
	{
		private const string LOG_TAG = "Wave.OpenXR.ViveCompositionLayer";

		public bool enableAutoFallback;

		public const string featureId = "vive.wave.openxr.feature.compositionlayer";

		public const string kOpenxrExtensionStrings = "";

		private bool m_XrInstanceCreated;

		private XrInstance m_XrInstance;

		private XrSystemId m_XrSystemId;

		private bool m_XrSessionCreated;

		private XrSession m_XrSession;

		private bool m_XrSessionEnding;

		private XrSpace m_WorldLockSpaceOriginOnHead;

		private XrSpace m_WorldLockSpaceOriginOnFloor;

		private XrSpace m_HeadLockSpace;

		private XrSessionState m_XrSessionNewState;

		private XrSessionState m_XrSessionOldState;

		private OpenXRHelper.xrGetInstanceProcAddrDelegate XrGetInstanceProcAddr;

		private OpenXRHelper.xrGetSystemPropertiesDelegate xrGetSystemProperties;

		private OpenXRHelper.xrEnumerateReferenceSpacesDelegate xrEnumerateReferenceSpaces;

		private OpenXRHelper.xrCreateReferenceSpaceDelegate xrCreateReferenceSpace;

		private OpenXRHelper.xrDestroySpaceDelegate xrDestroySpace;

		private const string ExtLib = "waveopenxr";

		public bool XrInstanceCreated => false;

		public bool XrSessionCreated => false;

		public bool XrSessionEnding => false;

		public XrSpace WorldLockSpaceOriginOnHead => default(XrSpace);

		public XrSpace WorldLockSpaceOriginOnFloor => default(XrSpace);

		public XrSpace HeadLockSpace => default(XrSpace);

		public XrSessionState XrSessionCurrentState => default(XrSessionState);

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

		protected override void OnInstanceDestroy(ulong xrInstance)
		{
		}

		protected override void OnSystemChange(ulong xrSystem)
		{
		}

		protected override void OnSessionCreate(ulong xrSession)
		{
		}

		protected override void OnSessionBegin(ulong xrSession)
		{
		}

		protected override void OnSessionEnd(ulong xrSession)
		{
		}

		protected override void OnSessionDestroy(ulong xrSession)
		{
		}

		protected override void OnSessionStateChange(int oldState, int newState)
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

		private bool GetXrFunctionDelegates(XrInstance xrInstance)
		{
			return false;
		}

		[PreserveSig]
		public static extern int WaveOpenXR_CompositionLayer_Init(XrSession session, uint textureWidth, uint textureHeight, GraphicsAPI graphicsAPI, bool isDynamic, bool isProtected, out uint imageCount);

		public int CompositionLayer_Init(uint textureWidth, uint textureHeight, GraphicsAPI graphicsAPI, bool isDynamic, bool isProtected, out uint imageCount)
		{
			imageCount = default(uint);
			return 0;
		}

		[PreserveSig]
		public static extern IntPtr WaveOpenXR_CompositionLayer_GetTexture(int layerID, out uint imageIndex);

		public IntPtr CompositionLayer_GetTexture(int layerID, out uint imageIndex)
		{
			imageIndex = default(uint);
			return (IntPtr)0;
		}

		[PreserveSig]
		public static extern bool WaveOpenXR_CompositionLayer_ReleaseTexture(int layerID);

		public bool CompositionLayer_ReleaseTexture(int layerID)
		{
			return false;
		}

		[PreserveSig]
		public static extern bool WaveOpenXR_CompositionLayer_Destroy(int layerID);

		public bool CompositionLayer_Destroy(int layerID)
		{
			return false;
		}

		[PreserveSig]
		public static extern void WaveOpenXR_Submit_CompositionLayerQuad(XrCompositionLayerQuad quad, LayerType layerType, uint compositionDepth, int layerID);

		public void Submit_CompositionLayerQuad(XrCompositionLayerQuad quad, LayerType layerType, uint compositionDepth, int layerID)
		{
		}

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr CompositionLayer_GetInstanceProcAddr(IntPtr func);

		[PreserveSig]
		public static extern XrResult WaveOpenXR_CompositionLayer_GetFuncAddrs(XrInstance xrInstance, IntPtr xrGetInstanceProcAddrFuncPtr);

		public XrResult CompositionLayer_GetFuncAddrs(XrInstance xrInstance, IntPtr xrGetInstanceProcAddrFuncPtr)
		{
			return default(XrResult);
		}
	}
}
