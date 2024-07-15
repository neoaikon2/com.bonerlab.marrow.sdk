namespace Wave.OpenXR.Hand
{
	public static class ViveHandTrackingHelper
	{
		public delegate XrResult xrCreateHandTrackerEXTDelegate(XrSession session, ref XrHandTrackerCreateInfoEXT createInfo, out XrHandTrackerEXT handTracker);

		public delegate XrResult xrDestroyHandTrackerEXTDelegate(XrHandTrackerEXT handTracker);

		public delegate XrResult xrLocateHandJointsEXTDelegate(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT locateInfo, ref XrHandJointLocationsEXT locations);

		public const int XR_HAND_JOINT_COUNT_EXT = 26;
	}
}
