using System.Collections.Generic;
using UnityEngine.XR;

namespace Wave.OpenXR
{
	public static class ClientInterface
	{
		private static List<XRInputSubsystem> s_InputSubsystems;

		public static bool IsUserPresence()
		{
			return false;
		}

		public static TrackingOriginModeFlags TrackingOrigin()
		{
			return default(TrackingOriginModeFlags);
		}
	}
}
