using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Marrow
{
	[DefaultExecutionOrder(9100)]
	public class Mirror : MonoBehaviour
	{
		[ReadOnly(false)]
		public RigManager rigManager;

		[ReadOnly(false)]
		[SerializeField]
		private SLZ.VRMK.Avatar _reflection;

		[SerializeField]
		private SerializableDictionary<Barcode, SLZ.VRMK.Avatar> _cachedReflections;

		[SerializeField]
		private Transform _reflectTran;

		[SerializeField]
		private Transform _avatarsTran;

		[SerializeField]
		private Transform _reflectionInitalTran;

		[SerializeField]
		public UniTask.Awaiter globalAwaiter;

		private Action swapperAction;

		public SLZ.VRMK.Avatar Reflection => null;

		private void OnTriggerEnter(Collider c)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		private void LateUpdate()
		{
		}

		private void WriteTransforms()
		{
		}
		private UniTask SwapReflectionAvatar()
		{
			return default(UniTask);
		}
		private UniTask SwapReflectionAvatar(Barcode barcode)
		{
			return default(UniTask);
		}
	}
}
