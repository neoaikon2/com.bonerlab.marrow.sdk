using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Features;
using UnityEngine.XR.OpenXR.Input;

namespace Wave.OpenXR.Tracker
{
	public class ViveWristTracker : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Vive Wrist Tracker (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" }, isGenericTypeOfDevice = true)]
		public class WristTrackerDevice : OpenXRDevice
		{
			private const string LOG_TAG = "Wave.OpenXR.Tracker.ViveWristTracker.WristTrackerDevice";

			[Preserve]
			[InputControl(aliases = new string[] { "A", "X", "buttonA", "buttonX" }, usage = "PrimaryButton")]
			public ButtonControl primaryButton { get; private set; }

			[Preserve]
			[InputControl(offset = 0u, aliases = new string[] { "device", "entityPose" }, usage = "Device")]
			public PoseControl devicePose { get; private set; }

			[Preserve]
			[InputControl(offset = 24u, usage = "IsTracked")]
			public ButtonControl isTracked { get; private set; }

			[Preserve]
			[InputControl(offset = 28u, usage = "TrackingState")]
			public IntegerControl trackingState { get; private set; }

			[Preserve]
			[InputControl(offset = 32u, alias = "gripPosition")]
			public Vector3Control devicePosition { get; private set; }

			[InputControl(offset = 44u, alias = "gripOrientation")]
			[Preserve]
			public QuaternionControl deviceRotation { get; private set; }

			[InputControl(aliases = new string[] { "menuButton" }, usage = "MenuButton")]
			[Preserve]
			public ButtonControl menu { get; private set; }

			private void DEBUG(string msg)
			{
			}

			protected override void FinishSetup()
			{
			}
		}

		private const string LOG_TAG = "Wave.OpenXR.Tracker.ViveWristTracker";

		public const string kOpenxrExtensionString = "XR_HTC_vive_wrist_tracker_interaction";

		public const string featureId = "vive.wave.openxr.feature.tracker";

		private const string profile = "/interaction_profiles/htc/vive_wrist_tracker";

		private const string leftWrist = "/user/wrist_htc/left";

		private const string rightWrist = "/user/wrist_htc/right";

		public const string buttonX = "/input/x/click";

		public const string menu = "/input/menu/click";

		public const string buttonA = "/input/a/click";

		public const string system = "/input/system/click";

		public const string entityPose = "/input/entity_htc/pose";

		private bool m_XrInstanceCreated;

		private XrInstance m_XrInstance;

		private const string kLayoutName = "ViveWristTracker";

		private const string kDeviceLocalizedName = "Vive Wrist Tracker OpenXR";

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
