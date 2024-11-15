using System.Collections.Generic;
using DigitalOpus.MB.Core;
using UnityEngine;

public abstract class MB3_MeshBakerRoot : MonoBehaviour
{
	public class ZSortObjects
	{
		public class Item
		{
			public GameObject go;

			public Vector3 point;
		}

		public class ItemComparer : IComparer<Item>
		{
			public int Compare(Item a, Item b)
			{
				return 0;
			}
		}

		public Vector3 sortAxis;

		public void SortByDistanceAlongAxis(List<GameObject> gos)
		{
		}
	}

	public Vector3 sortAxis;

	[HideInInspector]
	public abstract MB2_TextureBakeResults textureBakeResults { get; set; }

	public virtual List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	public static bool DoCombinedValidate(MB3_MeshBakerRoot mom, MB_ObjsToCombineTypes objToCombineType, MB2_EditorMethodsInterface editorMethods, MB2_ValidationLevel validationLevel)
	{
		return false;
	}
}
