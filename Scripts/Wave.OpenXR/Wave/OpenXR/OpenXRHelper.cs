using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Wave.OpenXR
{
	public static class OpenXRHelper
	{
		public delegate XrResult xrCreateSessionDelegate(XrInstance instance, in XrSessionCreateInfo createInfo, XrSession session);

		public delegate XrResult xrGetInstanceProcAddrDelegate(XrInstance instance, string name, out IntPtr function);

		public delegate XrResult xrGetSystemPropertiesDelegate(XrInstance instance, XrSystemId systemId, ref XrSystemProperties properties);

		public delegate XrResult xrEnumerateReferenceSpacesDelegate(XrSession session, uint spaceCapacityInput, out uint spaceCountOutput, out XrReferenceSpaceType spaces);

		public delegate XrResult xrCreateReferenceSpaceDelegate(XrSession session, ref XrReferenceSpaceCreateInfo createInfo, out XrSpace space);

		public delegate XrResult xrDestroySpaceDelegate(XrSpace space);

		public static XrSpaceLocationFlags XR_SPACE_LOCATION_ORIENTATION_VALID_BIT;

		public static XrSpaceLocationFlags XR_SPACE_LOCATION_POSITION_VALID_BIT;

		public static XrSpaceLocationFlags XR_SPACE_LOCATION_ORIENTATION_TRACKED_BIT;

		public static XrSpaceLocationFlags XR_SPACE_LOCATION_POSITION_TRACKED_BIT;

		public static ulong XR_NULL_SYSTEM_ID;

		public static XrDuration XR_NO_DURATION;

		public static XrDuration XR_INFINITE_DURATION;

		public static uint XR_MIN_COMPOSITION_LAYERS_SUPPORTED;

		public static XrSpaceVelocityFlags XR_SPACE_VELOCITY_LINEAR_VALID_BIT;

		public static XrSpaceVelocityFlags XR_SPACE_VELOCITY_ANGULAR_VALID_BIT;

		public static bool VALIDATE(InputActionReference actionReference, out string msg)
		{
			msg = null;
			return false;
		}

		public static Vector3 ToUnityVector(this Vector3 xrVec)
		{
			return default(Vector3);
		}

		public static Vector3 ToUnityVector(this XrVector3f xrVec)
		{
			return default(Vector3);
		}

		public static Quaternion ToUnityQuaternion(this Quaternion xrQuat)
		{
			return default(Quaternion);
		}

		public static Quaternion ToUnityQuaternion(this XrQuaternionf xrQuat)
		{
			return default(Quaternion);
		}
	}
}
