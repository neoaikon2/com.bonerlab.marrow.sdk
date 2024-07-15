using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Features;
using UnityEngine.XR.OpenXR.Input;

namespace Wave.OpenXR.Hand
{
	public class ViveHandInteraction : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Vive Hand Interaction (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" }, isGenericTypeOfDevice = true)]
		public class HandInteractionDevice : OpenXRDevice
		{
			private const string LOG_TAG = "Wave.OpenXR.Hand.ViveHandInteraction.HandInteractionDevice";

			[Preserve]
			[InputControl(aliases = new string[] { "selectAxis, pinchStrength" }, usage = "Select")]
			public AxisControl selectValue { get; private set; }

			[InputControl(offset = 0u, alias = "aimPose", usage = "Pointer")]
			[Preserve]
			public PoseControl pointerPose { get; private set; }

			private void DEBUG(string msg)
			{
			}

			protected override void FinishSetup()
			{
			}
		}

		private const string LOG_TAG = "Wave.OpenXR.Hand.ViveHandInteraction";

		public const string kOpenxrExtensionString = "XR_HTC_hand_interaction";

		public const string featureId = "vive.wave.openxr.feature.hand.interaction";

		private const string profile = "/interaction_profiles/htc/hand_interaction";

		private const string leftHand = "/user/hand_htc/left";

		private const string rightHand = "/user/hand_htc/right";

		public const string selectValue = "/input/select/value";

		private const string pointerPose = "/input/aim/pose";

		private bool m_XrInstanceCreated;

		private XrInstance m_XrInstance;

		private const string kLayoutName = "ViveHandInteraction";

		private const string kDeviceLocalizedName = "Vive Hand Interaction OpenXR";

		private void DEBUG(string msg)
		{
		}

		private void WARNING(string msg)
		{
		}

		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		protected override void RegisterDeviceLayout()
		{
		}

		protected override void UnregisterDeviceLayout()
		{
		}

		protected override void RegisterActionMapsWithRuntime()
		{
		}
	}
}
