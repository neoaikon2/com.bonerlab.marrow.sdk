using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MB_TexArraySlice
{
	public bool considerMeshUVs;

	public List<MB_TexArraySliceRendererMatPair> sourceMaterials;

	public bool ContainsMaterial(Material mat)
	{
		return false;
	}

	public HashSet<Material> GetDistinctMaterials()
	{
		return null;
	}

	public bool ContainsMaterialAndMesh(Material mat, Mesh mesh)
	{
		return false;
	}

	public List<Material> GetAllUsedMaterials(List<Material> usedMats)
	{
		return null;
	}

	public List<GameObject> GetAllUsedRenderers(List<GameObject> allObjsFromTextureBaker)
	{
		return null;
	}
}
