using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_controller_driven_hand_poses_sample")]
public class OVRControllerDrivenHandPosesSample : MonoBehaviour
{
	[SerializeField]
	private Button buttonOff;

	[SerializeField]
	private Button buttonConforming;

	[SerializeField]
	private Button buttonNatural;

	public OVRCameraRig cameraRig;

	private void Awake()
	{
	}

	public void SetControllerDrivenHandPosesTypeToNone()
	{
	}

	public void SetControllerDrivenHandPosesTypeToControllerConforming()
	{
	}

	public void SetControllerDrivenHandPosesTypeToNatural()
	{
	}
}
