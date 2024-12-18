using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MBVersionConcrete : MBVersionInterface
	{
		private Vector2 _HALF_UV;

		public string version()
		{
			return null;
		}

		public int GetMajorVersion()
		{
			return 0;
		}

		public int GetMinorVersion()
		{
			return 0;
		}

		public bool GetActive(GameObject go)
		{
			return false;
		}

		public void SetActive(GameObject go, bool isActive)
		{
		}

		public void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		public UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		public void OptimizeMesh(Mesh m)
		{
		}

		public bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return false;
		}

		public Vector2[] GetMeshUV1s(Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		public Vector2[] GetMeshUVChannel(int channel, Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		public void MeshClear(Mesh m, bool t)
		{
		}

		public void MeshAssignUVChannel(int channel, Mesh m, Vector2[] uvs)
		{
		}

		public Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		public Transform[] GetBones(Renderer r, bool isSkinnedMeshWithBones)
		{
			return null;
		}

		public int GetBlendShapeFrameCount(Mesh m, int shapeIndex)
		{
			return 0;
		}

		public float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex)
		{
			return 0f;
		}

		public void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		public void ClearBlendShapes(Mesh m)
		{
		}

		public void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		public int MaxMeshVertexCount()
		{
			return 0;
		}

		public void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles)
		{
		}

		public bool GraphicsUVStartsAtTop()
		{
			return false;
		}

		public bool IsTextureReadable(Texture2D tex)
		{
			return false;
		}

		public bool CollectPropertyNames(List<ShaderTextureProperty> texPropertyNames, ShaderTextureProperty[] shaderTexPropertyNames, List<ShaderTextureProperty> _customShaderPropNames, Material resultMaterial, MB2_LogLevel LOG_LEVEL)
		{
			return false;
		}

		public void DoSpecialRenderPipeline_TexturePackerFastSetup(GameObject cameraGameObject)
		{
		}

		public ColorSpace GetProjectColorSpace()
		{
			return default(ColorSpace);
		}

		public MBVersion.PipelineType DetectPipeline()
		{
			return default(MBVersion.PipelineType);
		}

		public string UnescapeURL(string url)
		{
			return null;
		}
		public IEnumerator FindRuntimeMaterialsFromAddresses(MB2_TextureBakeResults texBakeResult, MB2_TextureBakeResults.CoroutineResult isComplete)
		{
			return null;
		}
	}
}
