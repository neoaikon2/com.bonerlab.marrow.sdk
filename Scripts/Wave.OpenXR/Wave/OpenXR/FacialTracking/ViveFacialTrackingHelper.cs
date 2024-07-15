namespace Wave.OpenXR.FacialTracking
{
	public static class ViveFacialTrackingHelper
	{
		public delegate XrResult xrCreateFacialTrackerHTCDelegate(XrSession session, ref XrFacialTrackerCreateInfoHTC createInfo, out XrFacialTrackerHTC facialTracker);

		public delegate XrResult xrDestroyFacialTrackerHTCDelegate(XrFacialTrackerHTC facialTracker);

		public delegate XrResult xrGetFacialExpressionsHTCDelegate(XrFacialTrackerHTC facialTracker, ref XrFacialExpressionsHTC facialExpressions);

		public const uint XR_FACIAL_EXPRESSION_EYE_COUNT_HTC = 14u;

		public const uint XR_FACIAL_EXPRESSION_LIP_COUNT_HTC = 37u;
	}
}
