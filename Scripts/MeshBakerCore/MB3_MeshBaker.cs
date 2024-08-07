using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_MeshBaker : MB3_MeshBakerCommon
{
	[SerializeField]
	protected MB3_MeshCombinerSingle _meshCombiner;

	public override MB3_MeshCombiner meshCombiner => null;

	public void BuildSceneMeshObject()
	{
	}

	public virtual bool ShowHide(GameObject[] gos, GameObject[] deleteGOs)
	{
		return false;
	}

	public virtual void ApplyShowHide()
	{
	}

	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return false;
	}

	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
	{
		return false;
	}

	public void OnDestroy()
	{
	}

	[ContextMenu("Static Setup")]
	public void StaticSetup()
	{
	}
}
