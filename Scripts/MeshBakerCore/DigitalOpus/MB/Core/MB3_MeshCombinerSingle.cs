using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class MB3_MeshCombinerSingle : MB3_MeshCombiner
	{
		public class MB3_MeshCombinerSimpleBones
		{
			private MB3_MeshCombinerSingle combiner;

			private List<MB_DynamicGameObject>[] boneIdx2dgoMap;

			private HashSet<int> boneIdxsToDelete;

			private HashSet<BoneAndBindpose> bonesToAdd;

			private Dictionary<BoneAndBindpose, int> boneAndBindPose2idx;

			private bool _didSetup;

			public MB3_MeshCombinerSimpleBones(MB3_MeshCombinerSingle cm)
			{
			}

			public HashSet<BoneAndBindpose> GetBonesToAdd()
			{
				return null;
			}

			public int GetNumBonesToDelete()
			{
				return 0;
			}

			public void BuildBoneIdx2DGOMapIfNecessary(int[] _goToDelete)
			{
			}

			public void FindBonesToDelete(MB_DynamicGameObject dgo)
			{
			}

			public int GetNewBonesLength()
			{
				return 0;
			}

			public bool CollectBonesToAddForDGO(MB_DynamicGameObject dgo, Renderer r, bool noExtraBonesForMeshRenderers, MeshChannelsCache meshChannelCache)
			{
				return false;
			}

			private List<MB_DynamicGameObject>[] _buildBoneIdx2dgoMap()
			{
				return null;
			}

			public void CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(Transform[] nbones, Matrix4x4[] nbindPoses, BoneWeight[] nboneWeights, int totalDeleteVerts)
			{
			}

			public static void AddBonesToNewBonesArrayAndAdjustBWIndexes(MB3_MeshCombinerSingle combiner, MB_DynamicGameObject dgo, Renderer r, int vertsIdx, Transform[] nbones, BoneWeight[] nboneWeights, MeshChannelsCache meshChannelCache)
			{
			}

			internal void CopyVertsNormsTansToBuffers(MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, Vector3[] nnorms, Vector4[] ntangs, Vector3[] nverts, Vector3[] normals, Vector4[] tangents, Vector3[] verts)
			{
			}
		}

		public enum MeshCreationConditions
		{
			NoMesh = 0,
			CreatedInEditor = 1,
			CreatedAtRuntime = 2,
			AssignedByUser = 3
		}

		[Serializable]
		public class SerializableIntArray
		{
			public int[] data;

			public SerializableIntArray()
			{
			}

			public SerializableIntArray(int len)
			{
			}
		}

		[Serializable]
		public class MB_DynamicGameObject : IComparable<MB_DynamicGameObject>
		{
			public int instanceID;

			public GameObject gameObject;

			public string name;

			public int vertIdx;

			public int blendShapeIdx;

			public int numVerts;

			public int numBlendShapes;

			public bool isSkinnedMeshWithBones;

			public int[] indexesOfBonesUsed;

			public int lightmapIndex;

			public Vector4 lightmapTilingOffset;

			public Vector3 meshSize;

			public bool show;

			public bool invertTriangles;

			public int[] submeshTriIdxs;

			public int[] submeshNumTris;

			public int[] targetSubmeshIdxs;

			public Rect[] uvRects;

			public Rect[] encapsulatingRect;

			public Rect[] sourceMaterialTiling;

			public Rect[] obUVRects;

			public int[] textureArraySliceIdx;

			public Material[] sourceSharedMaterials;

			public bool _beingDeleted;

			public int _triangleIdxAdjustment;

			[NonSerialized]
			public SerializableIntArray[] _tmpSubmeshTris;

			[NonSerialized]
			public Transform[] _tmpSMR_CachedBones;

			[NonSerialized]
			public Matrix4x4[] _tmpSMR_CachedBindposes;

			[NonSerialized]
			public BoneWeight[] _tmpSMR_CachedBoneWeights;

			[NonSerialized]
			public int[] _tmpSMRIndexesOfSourceBonesUsed;

			public int CompareTo(MB_DynamicGameObject b)
			{
				return 0;
			}
		}

		public class MeshChannels
		{
			public Vector3[] vertices;

			public Vector3[] normals;

			public Vector4[] tangents;

			public Vector2[] uv0raw;

			public Vector2[] uv0modified;

			public Vector2[] uv2;

			public Vector2[] uv3;

			public Vector2[] uv4;

			public Vector2[] uv5;

			public Vector2[] uv6;

			public Vector2[] uv7;

			public Vector2[] uv8;

			public Color[] colors;

			public BoneWeight[] boneWeights;

			public Matrix4x4[] bindPoses;

			public int[] triangles;

			public MBBlendShape[] blendShapes;
		}

		[Serializable]
		public class MBBlendShapeFrame
		{
			public float frameWeight;

			public Vector3[] vertices;

			public Vector3[] normals;

			public Vector3[] tangents;
		}

		[Serializable]
		public class MBBlendShape
		{
			public int gameObjectID;

			public GameObject gameObject;

			public string name;

			public int indexInSource;

			public MBBlendShapeFrame[] frames;
		}

		public class MeshChannelsCache
		{
			private MB2_LogLevel LOG_LEVEL;

			private MB2_LightmapOptions lightmapOption;

			protected Dictionary<int, MeshChannels> meshID2MeshChannels;

			private Vector2 _HALF_UV;

			public MeshChannelsCache(MB2_LogLevel ll, MB2_LightmapOptions lo)
			{
			}

			internal Vector3[] GetVertices(Mesh m)
			{
				return null;
			}

			internal Vector3[] GetNormals(Mesh m)
			{
				return null;
			}

			internal Vector4[] GetTangents(Mesh m)
			{
				return null;
			}

			internal Vector2[] GetUv0Raw(Mesh m)
			{
				return null;
			}

			internal Vector2[] GetUv0Modified(Mesh m)
			{
				return null;
			}

			internal Vector2[] GetUVChannel(int channel, Mesh m)
			{
				return null;
			}

			internal Color[] GetColors(Mesh m)
			{
				return null;
			}

			internal Matrix4x4[] GetBindposes(Renderer r, out bool isSkinnedMeshWithBones)
			{
				isSkinnedMeshWithBones = default(bool);
				return null;
			}

			internal BoneWeight[] GetBoneWeights(Renderer r, int numVertsInMeshBeingAdded, bool isSkinnedMeshWithBones)
			{
				return null;
			}

			internal int[] GetTriangles(Mesh m)
			{
				return null;
			}

			internal MBBlendShape[] GetBlendShapes(Mesh m, int gameObjectID, GameObject gameObject)
			{
				return null;
			}

			private Color[] _getMeshColors(Mesh m)
			{
				return null;
			}

			private Vector3[] _getMeshNormals(Mesh m)
			{
				return null;
			}

			private Vector4[] _getMeshTangents(Mesh m)
			{
				return null;
			}

			private Vector2[] _getMeshUVs(Mesh m)
			{
				return null;
			}

			private Vector2[] _getMeshUV2s(Mesh m)
			{
				return null;
			}

			public static Matrix4x4[] _getBindPoses(Renderer r, out bool isSkinnedMeshWithBones)
			{
				isSkinnedMeshWithBones = default(bool);
				return null;
			}

			public static BoneWeight[] _getBoneWeights(Renderer r, int numVertsInMeshBeingAdded, bool isSkinnedMeshWithBones)
			{
				return null;
			}

			private void _generateTangents(int[] triangles, Vector3[] verts, Vector2[] uvs, Vector3[] normals, Vector4[] outTangents)
			{
			}
		}

		public struct BoneAndBindpose
		{
			public Transform bone;

			public Matrix4x4 bindPose;

			public BoneAndBindpose(Transform t, Matrix4x4 bp)
			{
				bone = null;
				bindPose = default(Matrix4x4);
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public class UVAdjuster_Atlas
		{
			private MB2_TextureBakeResults textureBakeResults;

			private MB2_LogLevel LOG_LEVEL;

			private int[] numTimesMatAppearsInAtlas;

			private MB_MaterialAndUVRect[] matsAndSrcUVRect;

			private bool compareNamesWhenComparingMaterials;

			public UVAdjuster_Atlas(MB2_TextureBakeResults tbr, MB2_LogLevel ll)
			{
			}

			public bool MapSharedMaterialsToAtlasRects(Material[] sharedMaterials, bool checkTargetSubmeshIdxsFromPreviousBake, Mesh m, MeshChannelsCache meshChannelsCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResultsCache, OrderedDictionary sourceMats2submeshIdx_map, GameObject go, MB_DynamicGameObject dgoOut)
			{
				return false;
			}

			public bool IsSameMaterialInTextureBakeResult(Material a, Material b)
			{
				return false;
			}

			public void _copyAndAdjustUVsFromMesh(MB2_TextureBakeResults tbr, MB_DynamicGameObject dgo, Mesh mesh, int uvChannel, int vertsIdx, Vector2[] uvsOut, float[] uvsSliceIdx, MeshChannelsCache meshChannelsCache)
			{
			}

			public bool TryMapMaterialToUVRect(Material mat, Mesh m, int submeshIdx, int idxInResultMats, MeshChannelsCache meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisCache, out MB_TextureTilingTreatment tilingTreatment, out Rect rectInAtlas, out Rect encapsulatingRectOut, out Rect sourceMaterialTilingOut, out int sliceIdx, ref string errorMsg, MB2_LogLevel logLevel)
			{
				tilingTreatment = default(MB_TextureTilingTreatment);
				rectInAtlas = default(Rect);
				encapsulatingRectOut = default(Rect);
				sourceMaterialTilingOut = default(Rect);
				sliceIdx = default(int);
				return false;
			}
		}

		[SerializeField]
		protected List<GameObject> objectsInCombinedMesh;

		[SerializeField]
		private int lightmapIndex;

		[SerializeField]
		private List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh;

		private Dictionary<GameObject, MB_DynamicGameObject> _instance2combined_map;

		[SerializeField]
		private Vector3[] verts;

		[SerializeField]
		private Vector3[] normals;

		[SerializeField]
		private Vector4[] tangents;

		[SerializeField]
		private Vector2[] uvs;

		[SerializeField]
		private float[] uvsSliceIdx;

		[SerializeField]
		private Vector2[] uv2s;

		[SerializeField]
		private Vector2[] uv3s;

		[SerializeField]
		private Vector2[] uv4s;

		[SerializeField]
		private Vector2[] uv5s;

		[SerializeField]
		private Vector2[] uv6s;

		[SerializeField]
		private Vector2[] uv7s;

		[SerializeField]
		private Vector2[] uv8s;

		[SerializeField]
		private Color[] colors;

		[SerializeField]
		private Matrix4x4[] bindPoses;

		[SerializeField]
		private Transform[] bones;

		[SerializeField]
		internal MBBlendShape[] blendShapes;

		[SerializeField]
		internal MBBlendShape[] blendShapesInCombined;

		[SerializeField]
		private SerializableIntArray[] submeshTris;

		[SerializeField]
		private MeshCreationConditions _meshBirth;

		[SerializeField]
		private Mesh _mesh;

		private BoneWeight[] boneWeights;

		private GameObject[] empty;

		private int[] emptyIDs;

		public override MB2_TextureBakeResults textureBakeResults
		{
			set
			{
			}
		}

		public override MB_RenderType renderType
		{
			set
			{
			}
		}

		public override GameObject resultSceneObject
		{
			set
			{
			}
		}

		private MB_DynamicGameObject instance2Combined_MapGet(GameObject gameObjectID)
		{
			return null;
		}

		private void instance2Combined_MapAdd(GameObject gameObjectID, MB_DynamicGameObject dgo)
		{
		}

		private void instance2Combined_MapRemove(GameObject gameObjectID)
		{
		}

		private bool instance2Combined_MapTryGetValue(GameObject gameObjectID, out MB_DynamicGameObject dgo)
		{
			dgo = null;
			return false;
		}

		private int instance2Combined_MapCount()
		{
			return 0;
		}

		private void instance2Combined_MapClear()
		{
		}

		private bool instance2Combined_MapContainsKey(GameObject gameObjectID)
		{
			return false;
		}

		private bool InstanceID2DGO(int instanceID, out MB_DynamicGameObject dgoGameObject)
		{
			dgoGameObject = null;
			return false;
		}

		public override int GetNumObjectsInCombined()
		{
			return 0;
		}

		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		public Mesh GetMesh()
		{
			return null;
		}

		public void SetMesh(Mesh m)
		{
		}

		public Transform[] GetBones()
		{
			return null;
		}

		public override int GetLightmapIndex()
		{
			return 0;
		}

		public override int GetNumVerticesFor(GameObject go)
		{
			return 0;
		}

		public override int GetNumVerticesFor(int instanceID)
		{
			return 0;
		}

		private bool _Initialize(int numResultMats)
		{
			return false;
		}

		private bool _collectMaterialTriangles(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map)
		{
			return false;
		}

		private bool _collectOutOfBoundsUVRects2(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResults, MeshChannelsCache meshChannelCache)
		{
			return false;
		}

		private bool _validateTextureBakeResults()
		{
			return false;
		}

		private bool _showHide(GameObject[] goToShow, GameObject[] goToHide)
		{
			return false;
		}

		private bool _addToCombined(GameObject[] goToAdd, int[] goToDelete, bool disableRendererInSource)
		{
			return false;
		}

		private void _copyAndAdjustUV2FromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
		{
		}

		private Transform[] _getBones(Renderer r, bool isSkinnedMeshWithBones)
		{
			return null;
		}

		public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		public virtual void ApplyShowHide()
		{
		}

		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapesFlag = false, GenerateUV2Delegate uv2GenerationMethod = null)
		{
		}

		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool uv5, bool uv6, bool uv7, bool uv8, bool colors, bool bones = false, bool blendShapesFlag = false, GenerateUV2Delegate uv2GenerationMethod = null)
		{
		}

		private int _numNonZeroLengthSubmeshTris(SerializableIntArray[] subTris)
		{
			return 0;
		}

		private void _updateMaterialsOnTargetRenderer(SerializableIntArray[] subTris, int numNonZeroLengthSubmeshTris)
		{
		}

		public SerializableIntArray[] GetSubmeshTrisWithShowHideApplied()
		{
			return null;
		}

		public override bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo)
		{
			return false;
		}

		public override bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo)
		{
			return false;
		}

		private bool _updateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo)
		{
			return false;
		}

		private bool _updateGameObject(GameObject go, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo, MeshChannelsCache meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResultsCache, OrderedDictionary sourceMats2submeshIdx_map, UVAdjuster_Atlas uVAdjuster)
		{
			return false;
		}

		public bool ShowHideGameObjects(GameObject[] toShow, GameObject[] toHide)
		{
			return false;
		}

		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return false;
		}

		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return false;
		}

		public override bool CombinedMeshContains(GameObject go)
		{
			return false;
		}

		public override void ClearBuffers()
		{
		}

		private Mesh NewMesh()
		{
			return null;
		}

		public override void ClearMesh()
		{
		}

		public override void ClearMesh(MB2_EditorMethodsInterface editorMethods)
		{
		}

		public override void DisposeRuntimeCreated()
		{
		}

		public override void DestroyMesh()
		{
		}

		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		public bool ValidateTargRendererAndMeshAndResultSceneObj()
		{
			return false;
		}

		private OrderedDictionary BuildSourceMatsToSubmeshIdxMap(int numResultMats)
		{
			return null;
		}

		internal Renderer BuildSceneHierarchPreBake(MB3_MeshCombinerSingle mom, GameObject root, Mesh m, bool createNewChild = false, GameObject[] objsToBeAdded = null)
		{
			return null;
		}

		public static void BuildPrefabHierarchy(MB3_MeshCombinerSingle mom, GameObject instantiatedPrefabRoot, Mesh m, bool createNewChild = false, GameObject[] objsToBeAdded = null)
		{
		}

		private static void _ConfigureSceneHierarch(MB3_MeshCombinerSingle mom, GameObject root, MeshRenderer mr, MeshFilter mf, SkinnedMeshRenderer smr, Mesh m, GameObject[] objsToBeAdded = null)
		{
		}

		public void BuildSceneMeshObject(GameObject[] gos = null, bool createNewChild = false)
		{
		}

		private bool IsMirrored(Matrix4x4 tm)
		{
			return false;
		}

		public override void CheckIntegrity()
		{
		}

		private void _copyUV2unchangedToSeparateRects()
		{
		}

		public override List<Material> GetMaterialsOnTargetRenderer()
		{
			return null;
		}

		public static MBBlendShape[] GetBlendShapes(Mesh m, int gameObjectID, GameObject gameObject, Dictionary<int, MeshChannels> meshID2MeshChannels)
		{
			return null;
		}

		private void ApplyBlendShapeFramesToMeshAndBuildMap()
		{
		}

		private string ConvertBlendShapeNameToOutputName(string bs)
		{
			return null;
		}

		private void ApplyBlendShapeFramesToMeshAndBuildMap_MergeBlendShapesWithTheSameName()
		{
		}

		private void BuildSrcShape2CombinedMap(SerializableSourceBlendShape2Combined map, MBBlendShape[] bs)
		{
		}

		[Obsolete("BuildSourceBlendShapeToCombinedIndexMap is deprecated. The map will be now be attached to the combined SkinnedMeshRenderer object as the MB_BlendShape2CombinedMap Component.")]
		public override Dictionary<MBBlendShapeKey, MBBlendShapeValue> BuildSourceBlendShapeToCombinedIndexMap()
		{
			return null;
		}

		private void _ZeroArray(Vector3[] arr, int idx, int length)
		{
		}

		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}
	}
}
