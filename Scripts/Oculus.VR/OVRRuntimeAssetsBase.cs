using UnityEngine;

public class OVRRuntimeAssetsBase : ScriptableObject
{
	internal static void LoadAsset<T>(out T assetInstance, string assetName) where T : OVRRuntimeAssetsBase
	{
		assetInstance = null;
	}
}
