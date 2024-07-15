using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Features;
using UnityEngine.XR.OpenXR.Input;

namespace Wave.OpenXR
{
	public class VIVEFocus3Profile : OpenXRInteractionFeature
	{
		[InputControlLayout(displayName = "VIVE Focus 3 Controller (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		[Preserve]
		public class VIVEFocus3Controller : XRControllerWithRumble
		{
			[Preserve]
			[InputControl(aliases = new string[] { "Primary2DAxis", "joystick", "joystickAxis", "thumbstickAxis" }, usage = "Primary2DAxis")]
			public Vector2Control thumbstick { get; private set; }

			[Preserve]
			[InputControl(aliases = new string[] { "GripAxis", "squeeze" }, usage = "Grip")]
			public AxisControl grip { get; private set; }

			[Preserve]
			[InputControl(aliases = new string[] { "GripButton", "squeezeClick" }, usage = "GripButton")]
			public ButtonControl gripPressed { get; private set; }

			[Preserve]
			[InputControl(aliases = new string[] { "menuButton" }, usage = "MenuButton")]
			public ButtonControl menu { get; private set; }

			[Preserve]
			[InputControl(aliases = new string[] { "A", "X", "buttonA", "buttonX" }, usage = "PrimaryButton")]
			public ButtonControl primaryButton { get; private set; }

			[InputControl(aliases = new string[] { "B", "Y", "buttonB", "buttonY" }, usage = "SecondaryButton")]
			[Preserve]
			public ButtonControl secondaryButton { get; private set; }

			[InputControl(aliases = new string[] { "triggerAxis" }, usage = "Trigger")]
			[Preserve]
			public AxisControl trigger { get; private set; }

			[InputControl(aliases = new string[] { "triggerButton", "triggerClick" }, usage = "TriggerButton")]
			[Preserve]
			public ButtonControl triggerPressed { get; private set; }

			[InputControl(aliases = new string[] { "triggerTouch", "indexTouch", "indexNearTouched" }, usage = "TriggerTouch")]
			[Preserve]
			public ButtonControl triggerTouched { get; private set; }

			[InputControl(aliases = new string[] { "Primary2DAxisClick", "joystickPress", "joystickClick" }, usage = "Primary2DAxisClick")]
			[Preserve]
			public ButtonControl thumbstickClicked { get; private set; }

			[Preserve]
			[InputControl(aliases = new string[] { "Primary2DAxisTouch", "joystickTouch" }, usage = "Primary2DAxisTouch")]
			public ButtonControl thumbstickTouched { get; private set; }

			[InputControl(offset = 0u, aliases = new string[] { "device", "gripPose" }, usage = "Device")]
			[Preserve]
			public UnityEngine.XR.OpenXR.Input.PoseControl devicePose { get; private set; }

			[Preserve]
			[InputControl(offset = 0u, alias = "aimPose", usage = "Pointer")]
			public UnityEngine.XR.OpenXR.Input.PoseControl pointerPose { get; private set; }

			[InputControl(offset = 24u, usage = "IsTracked")]
			[Preserve]
			public new ButtonControl isTracked { get; private set; }

			[Preserve]
			[InputControl(offset = 28u, usage = "TrackingState")]
			public new IntegerControl trackingState { get; private set; }

			[Preserve]
			[InputControl(offset = 32u, alias = "gripPosition")]
			public new Vector3Control devicePosition { get; private set; }

			[Preserve]
			[InputControl(offset = 44u, alias = "gripOrientation")]
			public new QuaternionControl deviceRotation { get; private set; }

			[Preserve]
			[InputControl(offset = 92u)]
			public Vector3Control pointerPosition { get; private set; }

			[InputControl(offset = 104u, alias = "pointerOrientation")]
			[Preserve]
			public QuaternionControl pointerRotation { get; private set; }

			protected override void FinishSetup()
			{
			}
		}

		public const string kOpenxrExtensionString = "XR_HTC_vive_focus3_controller_interaction";

		public const string featureId = "vive.wave.openxr.feature.focus3controller";

		public const string profile = "/interaction_profiles/htc/vive_focus3_controller";

		public const string buttonX = "/input/x/click";

		public const string buttonY = "/input/y/click";

		public const string menu = "/input/menu/click";

		public const string buttonA = "/input/a/click";

		public const string buttonB = "/input/b/click";

		public const string system = "/input/system/click";

		public const string grip = "/input/squeeze/value";

		public const string gripPress = "/input/squeeze/click";

		public const string gripTouch = "/input/squeeze/touch";

		public const string trigger = "/input/trigger/value";

		public const string triggerClick = "/input/trigger/click";

		public const string triggerTouch = "/input/trigger/touch";

		public const string thumbstick = "/input/thumbstick";

		public const string thumbstickClick = "/input/thumbstick/click";

		public const string thumbstickTouch = "/input/thumbstick/touch";

		public const string thumbrest = "/input/thumbrest/touch";

		public const string gripPose = "/input/grip/pose";

		public const string pointerPose = "/input/aim/pose";

		public const string haptic = "/output/haptic";

		private const string kDeviceLocalizedName = "VIVE Focus 3 Controller OpenXR";

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
