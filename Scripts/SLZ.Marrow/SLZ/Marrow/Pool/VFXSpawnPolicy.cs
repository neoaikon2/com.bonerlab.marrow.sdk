using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	public class VFXSpawnPolicy : SpawnPolicy
	{
		private double _timeOfLastSpawn;

		private Poolee _lastSpawn;

		private readonly VFXSpawnPolicyData _data;

		public VFXSpawnPolicy(VFXSpawnPolicyData data)
			: base(null)
		{
		}
		public override UniTask<Poolee> Spawn(Pool pool, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null, Transform parent = null)
		{
			return default(UniTask<Poolee>);
		}
	}
}
