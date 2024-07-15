using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class MB3_TextureCombiner
	{
		public class CreateAtlasesCoroutineResult
		{
			public bool success;

			public bool isFinished;
		}

		internal class TemporaryTexture
		{
			internal string property;

			internal Texture2D texture;

			public TemporaryTexture(string prop, Texture2D tex)
			{
			}
		}

		public class CombineTexturesIntoAtlasesCoroutineResult
		{
			public bool success;

			public bool isFinished;
		}
		public MB2_LogLevel LOG_LEVEL;

		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[SerializeField]
		protected int _atlasPadding;

		[SerializeField]
		protected int _maxAtlasSize;

		[SerializeField]
		protected int _maxAtlasWidthOverride;

		[SerializeField]
		protected int _maxAtlasHeightOverride;

		[SerializeField]
		protected bool _useMaxAtlasWidthOverride;

		[SerializeField]
		protected bool _useMaxAtlasHeightOverride;

		[SerializeField]
		protected bool _resizePowerOfTwoTextures;

		[SerializeField]
		protected bool _fixOutOfBoundsUVs;

		[SerializeField]
		protected int _layerTexturePackerFastMesh;

		[SerializeField]
		protected int _maxTilingBakeSize;

		[SerializeField]
		protected bool _saveAtlasesAsAssets;

		[SerializeField]
		protected MB2_TextureBakeResults.ResultType _resultType;

		[SerializeField]
		protected MB2_PackingAlgorithmEnum _packingAlgorithm;

		[SerializeField]
		protected bool _meshBakerTexturePackerForcePowerOfTwo;

		[SerializeField]
		protected List<ShaderTextureProperty> _customShaderPropNames;

		[SerializeField]
		protected bool _normalizeTexelDensity;

		[SerializeField]
		protected bool _considerNonTextureProperties;

		protected bool _doMergeDistinctMaterialTexturesThatWouldExceedAtlasSize;

		private List<TemporaryTexture> _temporaryTextures;

		public static bool _RunCorutineWithoutPauseIsRunning;

		public MB2_TextureBakeResults textureBakeResults
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int atlasPadding
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int maxAtlasSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int maxAtlasWidthOverride
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int maxAtlasHeightOverride
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual bool useMaxAtlasWidthOverride
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool useMaxAtlasHeightOverride
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool resizePowerOfTwoTextures
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool fixOutOfBoundsUVs
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int layerTexturePackerFastMesh
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int maxTilingBakeSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool saveAtlasesAsAssets
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MB2_TextureBakeResults.ResultType resultType
		{
			get
			{
				return default(MB2_TextureBakeResults.ResultType);
			}
			set
			{
			}
		}

		public MB2_PackingAlgorithmEnum packingAlgorithm
		{
			get
			{
				return default(MB2_PackingAlgorithmEnum);
			}
			set
			{
			}
		}

		public bool meshBakerTexturePackerForcePowerOfTwo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<ShaderTextureProperty> customShaderPropNames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool considerNonTextureProperties
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool doMergeDistinctMaterialTexturesThatWouldExceedAtlasSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static void RunCorutineWithoutPause(IEnumerator cor, int recursionDepth)
		{
		}

		public bool CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods = null, List<AtlasPackingResult> packingResults = null, bool onlyPackRects = false, bool splitAtlasWhenPackingIfTooBig = false)
		{
			return false;
		}
		public IEnumerator CombineTexturesIntoAtlasesCoroutine(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods = null, CombineTexturesIntoAtlasesCoroutineResult coroutineResult = null, float maxTimePerFrame = 0.01f, List<AtlasPackingResult> packingResults = null, bool onlyPackRects = false, bool splitAtlasWhenPackingIfTooBig = false)
		{
			return null;
		}
		private IEnumerator _CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> atlasPackingResult, bool onlyPackRects, bool splitAtlasWhenPackingIfTooBig)
		{
			return null;
		}

		private MB3_TextureCombinerPipeline.TexturePipelineData LoadPipelineData(Material resultMaterial, List<ShaderTextureProperty> texPropertyNames, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, List<MB_TexSet> distinctMaterialTextures)
		{
			return null;
		}
		private IEnumerator __CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, MB3_TextureCombinerPipeline.TexturePipelineData data, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return null;
		}
		private IEnumerator __RunTexturePackerOnly(CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, MB3_TextureCombinerPipeline.TexturePipelineData data, bool splitAtlasWhenPackingIfTooBig, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> packingResult)
		{
			return null;
		}

		internal int _getNumTemporaryTextures()
		{
			return 0;
		}

		public Texture2D _createTemporaryTexture(string propertyName, int w, int h, TextureFormat texFormat, bool mipMaps, bool linear)
		{
			return null;
		}

		internal void AddTemporaryTexture(TemporaryTexture tt)
		{
		}

		internal Texture2D _createTextureCopy(string propertyName, Texture2D t)
		{
			return null;
		}

		internal Texture2D _resizeTexture(string propertyName, Texture2D t, int w, int h)
		{
			return null;
		}

		internal void _destroyAllTemporaryTextures()
		{
		}

		internal void _destroyTemporaryTextures(string propertyName)
		{
		}

		public void _restoreProceduralMaterials()
		{
		}

		public void SuggestTreatment(List<GameObject> objsToMesh, Material[] resultMaterials, List<ShaderTextureProperty> _customShaderPropNames)
		{
		}

		public static bool ShouldTextureBeLinear(ShaderTextureProperty shaderTextureProperty)
		{
			return false;
		}

		private string PrintList(List<GameObject> gos)
		{
			return null;
		}
	}
}
