using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow
{
	public static class ProjectileEmitter
	{
		public static void Register(ProjectileData projectileData)
		{
		}

		public static void Emit(ProjectileData projectileData, Transform EmittingTransform, TriggerRefProxy proxy = null)
		{
		}
		private static UniTaskVoid SpawnAsync(ProjectileData projectileData, Vector3 position, Quaternion rotation, Transform parentT, TriggerRefProxy proxy = null)
		{
			return default(UniTaskVoid);
		}
	}
}
