using JetBrains.Annotations;
using SLZ.Marrow.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow
{
	public abstract class MarrowLevelManager<TDataManager, TSave, TSettings, TPlayerSettings, TProgression, TUnlocks, TResumePoint> : MonoBehaviour where TDataManager : MarrowDataManager<TDataManager, TSave, TSettings, TPlayerSettings, TProgression, TUnlocks> where TSave : class, ISave<TPlayerSettings, TProgression, TUnlocks>, new() where TSettings : class, ISettings, new() where TPlayerSettings : class, IPlayerSettings, new() where TProgression : class, IProgression, new() where TUnlocks : class, IUnlocks, new() where TResumePoint : IResumePoint
	{
		protected bool _isLoadCalled;

		private static bool ShouldResumeProgressForThisLoad { get; set; }

		[Tooltip("Name of the level in the save data")]
		[field: SerializeField]
		public string LevelKey { get; protected set; }

		[Tooltip("Mark level complete after level load")]
		[field: SerializeField]
		public bool CompleteOnLoad { get; protected set; }

		[Tooltip("Does this level save completion/progress/inventory?")]
		[field: SerializeField]
		public SaveFeatures SaveFeatures { get; protected set; }

		[Tooltip("Amount of time to wait after triggering level load before actually loading the level.")]
		[field: SerializeField]
		protected double LevelLoadBufferTime { get; set; }

		[Tooltip("Crate reference to a fadeout VFX override, if any")]
		[field: SerializeField]
		public SpawnableCrateReference FadeoutVFXOverride { get; protected set; }

		[Tooltip("Crate references to levels to possibly load")]
		[field: SerializeField]
		public LevelCrateReference[] LevelJumpList { get; protected set; }

		[field: SerializeField]
		protected TResumePoint[] ProgressionPoint { get; set; }

		public int Progress { get; protected set; }

		public bool IsResuming { get; protected set; }

		private protected abstract TDataManager DataManager { get; }

		private protected abstract TSave ActiveSave { get; }

		public static void ThisLoadShouldResumeProgress()
		{
		}

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		private void TeleportToProgress()
		{
		}

		[PublicAPI]
		public void SetCompleted()
		{
		}

		[PublicAPI]
		public void SetProgress(int progress)
		{
		}

		[PublicAPI]
		public void JustSave()
		{
		}

		[PublicAPI]
		public void JustJumpToLevelAtIndex(int levelIndex = 0)
		{
		}

		[PublicAPI]
		private protected void JustJumpToLevelWithBarcode(Barcode levelBarcode)
		{
		}

		private protected virtual void PerformJump(LevelCrateReference nextLevel, LevelCrateReference loadScreenLevelOverride = null, SpawnableCrateReference fadeoutVfxOverride = null)
		{
		}

		private protected abstract void ResumeProgress();

		private protected abstract void OnProgressionRestore();

		private protected abstract void OnProgressionSave();
	}
}
