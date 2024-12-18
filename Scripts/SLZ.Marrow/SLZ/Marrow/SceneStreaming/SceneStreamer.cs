using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.SceneStreaming
{
	public static class SceneStreamer
	{
		private static StreamSession _session;

		public static Action doAnyLevelLoad;

		public static Action doAnyLevelUnload;

		public static StreamSession Session => null;

		public static void Load(Barcode levelBarcode, Barcode loadLevelBarcode = null)
		{
		}

		public static void Load(LevelCrateReference level, LevelCrateReference loadLevel)
		{
		}
		public static UniTask LoadAsync(LevelCrateReference level, LevelCrateReference loadLevel = null)
		{
			return default(UniTask);
		}

		public static void Reload()
		{
		}
		public static UniTask ReloadAsync()
		{
			return default(UniTask);
		}
	}
}
