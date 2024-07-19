using UnityEngine;

public class OVRRayHelper : MonoBehaviour
{
	public MeshRenderer Renderer;

	public Material NormalMaterial;

	public Material PinchMaterial;

	public GameObject Cursor;

	public SpriteRenderer CursorFill;

	private Vector3 _initialScale;

	public float DefaultLength;

	private Vector3 _cursorIntitialSize;

	private const float _cursorSelectedScaleFactor = 0.5f;

	private void Start()
	{
	}

	public void UpdatePointerRay(OVRInputRayData rayData)
	{
	}
}
