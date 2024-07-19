using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_hand_tracking_wide_motion_mode_sample")]
[DisallowMultipleComponent]
public class OVRHandTrackingWideMotionModeSample : MonoBehaviour
{
	[SerializeField]
	public Toggle fusionToggle;

	[SerializeField]
	private LineRenderer leftLinePointer;

	[SerializeField]
	private LineRenderer rightLinePointer;

	[SerializeField]
	private OVRHand handLeft;

	[SerializeField]
	private OVRHand handRight;

	[SerializeField]
	private OVRInputModule inputModule;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void UpdateLineRenderer()
	{
	}

	private void UpdateLineRendererForHand(bool isLeft)
	{
	}

	public void OnFusionToggleChanged(bool newValue)
	{
	}
}
